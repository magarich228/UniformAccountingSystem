using System.ComponentModel.DataAnnotations;

namespace UniformAccountingSystem.BLL.Dtos
{
    public class ReceiptItemDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UniformId { get; set; }

        [Range(1, 99999)]
        public int Amount { get; set; } = 1;

        public Guid ReceiptId { get; set; }
    }
}
