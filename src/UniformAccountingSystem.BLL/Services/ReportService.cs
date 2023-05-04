using Microsoft.EntityFrameworkCore;
using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Dtos;
using UniformAccountingSystem.Data;
using UniformAccountingSystem.Data.Entities;

namespace UniformAccountingSystem.BLL.Services
{
    public class ReportService : IReportService
    {
        private readonly UniformAccountingContext _db;

        public ReportService(UniformAccountingContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<UniformDiscardDto>> GetUniformDiscards() =>
            await _db.Discards.Select(d => Mapping.Map<UniformDiscard, UniformDiscardDto>(d)).ToListAsync();

        public async Task<IEnumerable<UniformIssuanceDto>> GetUniformIssuances() =>
            await _db.Issues.Select(i => Mapping.Map<UniformIssuance, UniformIssuanceDto>(i)).ToListAsync();

        public async Task<IEnumerable<UniformReceiptDto>> GetUniformReceipts() =>
            await _db.Receipts.Select(r => Mapping.Map<UniformReceipt, UniformReceiptDto>(r)).ToListAsync();
    }
}
