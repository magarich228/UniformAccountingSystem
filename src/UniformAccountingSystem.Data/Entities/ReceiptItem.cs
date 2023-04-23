namespace UniformAccountingSystem.Data.Entities
{
    public class ReceiptItem
    {
        public Guid Id { get; set; }

        public Guid UniformId { get; set; }

        public int Amount { get; set; } = 1;

        public Guid ReceiptId { get; set; }

        public Uniform? Uniform { get; set; }

        public UniformReceipt? Receipt { get; set; }
    }
}
