using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Dtos;
using UniformAccountingSystem.Data;

namespace UniformAccountingSystem.BLL.Services
{
    public class VendorManager : IVendorManager
    {
        private readonly UniformAccountingContext _db;

        public VendorManager(UniformAccountingContext db)
        {
            _db = db;
        }

        public Task<Guid> AddAsync(VendorDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<VendorDto> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VendorDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<VendorDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<VendorDto> UpdateAsync(VendorDto vendorDto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
