using UniformAccountingSystem.BLL.Dtos;

namespace UniformAccountingSystem.BLL.Abstractions
{
    public interface IVendorManager
    {
        Task<IEnumerable<VendorDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<VendorDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<Guid?> AddAsync(VendorDto entity, CancellationToken cancellationToken = default);
        Task<VendorDto?> UpdateAsync(VendorDto vendorDto, CancellationToken cancellationToken = default);
        Task<bool?> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
