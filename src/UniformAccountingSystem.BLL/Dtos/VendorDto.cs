using System.ComponentModel.DataAnnotations;

namespace UniformAccountingSystem.BLL.Dtos
{
    public class VendorDto
    {
        public Guid Id { get; set; }

        [StringLength(100), Required]
        public string Name { get; set; } = null!;

        [StringLength(200)]
        public string? Description { get; set; }

        [StringLength(50), Required]
        public string Phone { get; set; } = null!;

        [StringLength(100)]
        public string? Email { get; set; }
    }
}
