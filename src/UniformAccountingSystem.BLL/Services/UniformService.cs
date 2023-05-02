using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Dtos;
using UniformAccountingSystem.Data;
using UniformAccountingSystem.Data.Entities;

namespace UniformAccountingSystem.BLL.Services
{
    public class UniformService : IUniformService
    {
        private readonly UniformAccountingContext _db;
        private readonly IMapper _mapper;

        public UniformService(
            UniformAccountingContext db, 
            IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UniformDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var uniforms = await _db.Uniforms.ToListAsync(cancellationToken);

            return uniforms.Select(u => Mapping.Map<Uniform, UniformDto>(u));
        }

        public async Task<Guid?> AddAsync(UniformDto uniformDto, CancellationToken cancellationToken = default)
        {
            Uniform uniform = Mapping.Map<UniformDto, Uniform>(uniformDto);
            uniform.UniformTypeRef = await _db.UniformTypes.FindAsync(
                new object[] { _mapper.Map<Dtos.UniformType, Data.Entities.UniformType>(uniformDto.UniformType) }, 
                cancellationToken: cancellationToken);
            
            _db.Uniforms.Add(uniform);

            return (await _db.SaveChangesAsync(cancellationToken)) > 0 ? 
                uniform.Id : 
                null;
        }

        public async Task<bool> DeleteByIdAsync(Guid uniformId, CancellationToken cancellationToken = default)
        {
            var uniform = await _db.FindAsync<Uniform>(new object[] { uniformId }, cancellationToken: cancellationToken);

            if (uniform == null)
                return false;

            _db.Uniforms.Remove(uniform);

            return (await _db.SaveChangesAsync(cancellationToken)) > 0;
        }

        public async Task<UniformDto?> UpdateAsync(UniformDto uniformDto, CancellationToken cancellationToken = default)
        {
            var uniform = await _db.FindAsync<Uniform>(new object[] { uniformDto.Id }, cancellationToken: cancellationToken);

            if (uniform == null)
                return null;

            uniform.Name = uniformDto.Name;
            uniform.UniformType = Enum.Parse<Data.Entities.UniformType>(uniformDto.UniformType.ToString());
            uniform.Price = uniformDto.Price;

            _db.Uniforms.Update(uniform);

            return (await _db.SaveChangesAsync(cancellationToken)) > 0 ?
                uniformDto : 
                null;
        }
    }
}
