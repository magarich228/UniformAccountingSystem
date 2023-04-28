using System.ComponentModel.DataAnnotations;

namespace UniformAccountingSystem.BLL.Dtos
{
    public class IssuanceItemDto
    {
        public Guid Id { get; set; }

        public Guid UniformId { get; set; }

        [Range(0, 9999999)]
        public int Amount { get; set; } = 1;

        public Guid IssuanceId { get; set; }
    }
}
