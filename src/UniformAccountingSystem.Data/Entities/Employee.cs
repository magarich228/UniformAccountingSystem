namespace UniformAccountingSystem.Data.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Patronymic { get; set; } = null!;

        public string WorkPosition { get; set; } = null!;

        public EmployeeState State { get; set; } = EmployeeState.Active;
    }

    public enum EmployeeState : int
    {
        Active = 0,
        Inactive = 1
    }
}
