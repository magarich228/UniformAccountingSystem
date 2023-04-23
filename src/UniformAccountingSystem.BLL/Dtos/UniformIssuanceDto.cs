using System.ComponentModel.DataAnnotations;

namespace UniformAccountingSystem.BLL.Dtos
{
    public class UniformIssuanceDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime IssuanceDate { get; set; } = DateTime.UtcNow;

        [StringLength(200)]
        public string? Desctiption { get; set; }

        public Guid EmployeeId { get; set; }

        public IssuanceAction IssuanceAction { get; set; } = IssuanceAction.Issuance;
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
