namespace UniformAccountingSystem.Data.Entities
{
    public class UniformVendor
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public string Phone { get; set; } = null!;

        public string? Email { get; set; }
    }
}
