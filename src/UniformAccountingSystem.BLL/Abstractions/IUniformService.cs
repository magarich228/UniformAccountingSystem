using UniformAccountingSystem.BLL.Dtos;

namespace UniformAccountingSystem.BLL.Abstractions
{
    public interface IUniformService
    {
        Task<IEnumerable<UniformDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Guid?> AddAsync(UniformDto uniformDto, CancellationToken cancellationToken = default);
        Task<UniformDto> UpdateAsync(UniformDto uniformDto, CancellationToken cancellationToken = default);
    }
}
