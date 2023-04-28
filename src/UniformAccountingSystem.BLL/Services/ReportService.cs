using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Dtos;
using UniformAccountingSystem.Data;

namespace UniformAccountingSystem.BLL.Services
{
    public class ReportService : IReportService
    {
        private readonly UniformAccountingContext _db;

        public ReportService(UniformAccountingContext db)
        {
            _db = db;
        }

        public Task<IEnumerable<UniformDiscardDto>> GetUniformDiscards()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UniformIssuanceDto>> GetUniformIssuances()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UniformReceiptDto>> GetUniformReceipts()
        {
            throw new NotImplementedException();
        }
    }
}
