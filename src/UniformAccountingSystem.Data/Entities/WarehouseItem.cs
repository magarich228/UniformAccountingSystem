namespace UniformAccountingSystem.Data.Entities
{
    public class WarehouseItem
    {
        public Guid Id { get; set; }

        public Guid UniformId { get; set; }

        public int TotalAmount { get; set; }    

        public Uniform? Uniform { get; set; }
    }
}
