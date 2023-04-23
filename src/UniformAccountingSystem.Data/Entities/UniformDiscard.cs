namespace UniformAccountingSystem.Data.Entities
{
    public class UniformDiscard
    {
        public Guid Id { get; set; }

        public Guid UniformId { get; set; }
        
        public string? Reason { get; set; }

        public int Amount { get; set; }

        public Uniform? Uniform { get; set; }
    }
}
