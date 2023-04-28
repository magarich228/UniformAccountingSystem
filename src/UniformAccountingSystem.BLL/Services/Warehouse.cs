using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Dtos;
using UniformAccountingSystem.Data;

namespace UniformAccountingSystem.BLL.Services
{
    public class Warehouse : IWarehouse
    {
        private readonly UniformAccountingContext _db;

        public Warehouse(UniformAccountingContext db)
        {
            _db = db;
        }

        public Task DiscardAsync(UniformDiscardDto uniformDiscard, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WarehouseItemDto>> GetAllItemsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<WarehouseItemDto> GetByUniformIdAsync(Guid uniformId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task IssueAsync(UniformIssuanceDto uniformIssuance, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task ReceiptAsync(UniformReceiptDto uniformReceipt, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<UniformDiscardDto> UpdateDiscardAsync(UniformDiscardDto uniformDiscard, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<UniformIssuanceDto> UpdateIssuanceAsync(UniformIssuanceDto uniformIssuance, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<UniformReceiptDto> UpdateReceiptAsync(UniformReceiptDto uniformReceipt, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
