using UniformAccountingSystem.BLL.Dtos;

namespace UniformAccountingSystem.BLL.Abstractions
{
    public interface IReportService
    {
        Task<IEnumerable<UniformReceiptDto>> GetUniformReceipts();
        Task<IEnumerable<UniformDiscardDto>> GetUniformDiscards();
        Task<IEnumerable<UniformIssuanceDto>> GetUniformIssuances();
    }
}
