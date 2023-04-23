using System.ComponentModel.DataAnnotations;

namespace UniformAccountingSystem.BLL.Dtos
{
    public class UniformDiscardDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UniformId { get; set; }

        [StringLength(200)]
        public string? Reason { get; set; }

        [Range(0, 9999999)]
        public int Amount { get; set; }
    }
}
