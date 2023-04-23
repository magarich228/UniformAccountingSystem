namespace UniformAccountingSystem.Data.Entities
{
    public class UniformIssuance
    {
        public Guid Id { get; set; }

        public DateTime IssuanceDate { get; set; } = DateTime.UtcNow;

        public string? Desctiption { get; set; }

        public Guid EmployeeId { get; set; }

        public IssuanceAction IssuanceAction { get; set; } = IssuanceAction.Issuance;

        public Employee? Employee { get; set; }

        public List<IssuanceItem>? IssuanceItems { get; set;}
    }

    public enum IssuanceAction : int
    {
        /// <summary>
        /// Выдача.
        /// </summary>
        Issuance = 0,

        /// <summary>
        /// Возврат.
        /// </summary>
        Return = 1
    }
}
