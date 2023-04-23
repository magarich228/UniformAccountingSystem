using System.ComponentModel.DataAnnotations;

namespace UniformAccountingSystem.BLL.Dtos
{
    public class UniformReceiptDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime ReceiptDate { get; set; } = DateTime.UtcNow;

        [StringLength(200)]
        public string? Desctiption { get; set; }

        public Guid VendorId { get; set; }

        public List<ReceiptItemDto> ReceiptItems { get; set; } = new List<ReceiptItemDto>();
    }
}
