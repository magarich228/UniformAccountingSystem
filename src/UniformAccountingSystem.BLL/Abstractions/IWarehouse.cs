using UniformAccountingSystem.BLL.Dtos;

namespace UniformAccountingSystem.BLL.Abstractions
{
    public interface IWarehouse
    {
        Task<int> GetTotalAmountAsync(Guid uniformId, CancellationToken cancellationToken = default);
        Task<IEnumerable<WarehouseItemDto>> GetAllItemsAsync(CancellationToken cancellationToken = default);
        Task<WarehouseItemDto?> GetByUniformIdAsync(Guid uniformId, CancellationToken cancellationToken = default);
        Task ReceiptAsync(UniformReceiptDto uniformReceipt, CancellationToken cancellationToken = default);
        Task IssueAsync(UniformIssuanceDto uniformIssuance, CancellationToken cancellationToken = default);
        Task DiscardAsync(UniformDiscardDto uniformDiscard, CancellationToken cancellationToken = default);
    }
}
