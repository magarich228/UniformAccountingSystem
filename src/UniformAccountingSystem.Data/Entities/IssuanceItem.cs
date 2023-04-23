namespace UniformAccountingSystem.Data.Entities
{
    public class IssuanceItem
    {
        public Guid Id { get; set; }

        public Guid UniformId { get; set; }

        public int Amount { get; set; } = 1;

        public Guid IssuanceId { get; set; }

        public Uniform? Uniform { get; set; }

        public UniformIssuance? Issuance { get; set; }
    }
}
