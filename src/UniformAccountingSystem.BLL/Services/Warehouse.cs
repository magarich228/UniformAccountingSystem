using Microsoft.EntityFrameworkCore;
using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Dtos;
using UniformAccountingSystem.Data;
using UniformAccountingSystem.Data.Entities;

namespace UniformAccountingSystem.BLL.Services
{
    public class Warehouse : IWarehouse
    {
        private readonly UniformAccountingContext _db;

        public Warehouse(UniformAccountingContext db)
        {
            _db = db;
        }

        public async Task<int> GetTotalAmountAsync(Guid uniformId, CancellationToken cancellationToken = default)
        {
            var receipts = await _db.ReceiptItems
                    .Where(i => i.UniformId == uniformId)
                    .SumAsync(i => i.Amount, cancellationToken);

            var returns = await _db.IssuesItem.Include(i => i.Issuance)
                    .Where(i => i.UniformId == uniformId && i.Issuance!.IssuanceAction == Data.Entities.IssuanceAction.Return)
                    .SumAsync(i => i.Amount, cancellationToken);

            var discards = await _db.Discards.Where(d => d.UniformId == uniformId).SumAsync(d => d.Amount, cancellationToken);

            var issues = await _db.IssuesItem.Include(i => i.Issuance)
                    .Where(i => i.UniformId == uniformId && i.Issuance!.IssuanceAction == Data.Entities.IssuanceAction.Issuance)
                    .SumAsync(i => i.Amount, cancellationToken);

            var totalAmount = (receipts + returns) - (discards + issues);

            return totalAmount;
        }

        public async Task<IEnumerable<WarehouseItemDto>> GetAllItemsAsync(CancellationToken cancellationToken = default)
        {
            var items = new List<WarehouseItemDto>();

            foreach (var uniform in _db.Uniforms)
            {
                var totalAmount = await GetTotalAmountAsync(uniform.Id, cancellationToken);

                items.Add(new WarehouseItemDto
                {
                    Uniform = Mapping.Map<Uniform, UniformDto>(uniform),
                    TotalAmount = totalAmount
                });
            }

            return items;
        }

        public async Task<WarehouseItemDto?> GetByUniformIdAsync(Guid uniformId, CancellationToken cancellationToken = default) =>
            (await _db.Uniforms.FindAsync(new object[] { uniformId }, cancellationToken: cancellationToken) != null) ?
            new WarehouseItemDto
            {
                Uniform = Mapping.Map<Uniform, UniformDto>((await _db.Uniforms.FindAsync(new object[] { uniformId }, cancellationToken: cancellationToken))!),
                TotalAmount = await GetTotalAmountAsync(uniformId, cancellationToken)
            } :
            null;

        public async Task DiscardAsync(UniformDiscardDto uniformDiscard, CancellationToken cancellationToken = default)
        {
            var discard = Mapping.Map<UniformDiscardDto, UniformDiscard>(uniformDiscard);

            _db.Discards.Add(discard);
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task IssueAsync(UniformIssuanceDto uniformIssuance, CancellationToken cancellationToken = default)
        {
            var issue = Mapping.Map<UniformIssuanceDto, UniformIssuance>(uniformIssuance);

            _db.Issues.Add(issue);
            await _db.SaveChangesAsync(cancellationToken);
        }

        public async Task ReceiptAsync(UniformReceiptDto uniformReceipt, CancellationToken cancellationToken = default)
        {
            var receipt = Mapping.Map<UniformReceiptDto, UniformReceipt>(uniformReceipt);

            _db.Receipts.Add(receipt);
            await _db.SaveChangesAsync(cancellationToken);
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
