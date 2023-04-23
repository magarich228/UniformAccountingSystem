using System.ComponentModel.DataAnnotations;

namespace UniformAccountingSystem.BLL.Dtos
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; } = null!;

        [Required, StringLength(50)]
        public string LastName { get; set; } = null!;

        [Required, StringLength(50)]
        public string Patronymic { get; set; } = null!;

        [Required, StringLength(100)]
        public string WorkPosition { get; set; } = null!;

        [EnumDataType(typeof(EmployeeState))]
        public EmployeeState State { get; set; } = EmployeeState.Active;
    }

    public enum EmployeeState : int
    {
        Active = 0,
        Inactive = 1
    }
}
