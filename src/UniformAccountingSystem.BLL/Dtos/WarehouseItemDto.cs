namespace UniformAccountingSystem.BLL.Dtos
{
    public class WarehouseItemDto
    {
        public UniformDto Uniform { get; set; } = null!;

        public int TotalAmount { get; set; }
    }
}
