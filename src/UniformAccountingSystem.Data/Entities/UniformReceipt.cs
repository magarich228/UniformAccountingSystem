namespace UniformAccountingSystem.Data.Entities
{
    public class UniformReceipt
    {
        public Guid Id { get; set; }

        public DateTime ReceiptDate { get; set; } = DateTime.UtcNow;

        public string? Desctiption { get; set; }

        public Guid VendorId { get; set; }

        public UniformVendor? Vendor { get; set; }

        public List<ReceiptItem>? ReceiptItems { get; set; }
    }
}
