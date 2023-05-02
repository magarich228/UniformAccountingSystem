using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UniformAccountingSystem.BLL.Dtos
{
    public class UniformDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [StringLength(100), Required]
        public string Name { get; set; } = null!;

        [EnumDataType(typeof(UniformType))]
        public UniformType UniformType { get; set; } = UniformType.Other;

        [Range(0, 99999999)]
        public double Price { get; set; }
    }

    /// <summary>
    /// Вид спецодежды.
    /// </summary>
    public enum UniformType : int
    {
        /// <summary>
        /// Другое.
        /// </summary>
        [Description("Другое")]
        Other = 0,

        /// <summary>
        /// Футболка.
        /// </summary>
        [Description("Футболка")]
        TShirt = 1,

        /// <summary>
        /// Штаны.
        /// </summary>
        [Description("Штаны")]
        Patns = 2,

        /// <summary>
        /// Обувь.
        /// </summary>
        [Description("Обувь")]
        Shoes = 3,

        /// <summary>
        /// Халат.
        /// </summary>
        [Description("Халат")]
        Robe = 4,

        /// <summary>
        /// Костюм.
        /// </summary>
        [Description("Костюм")]
        Suit = 5,

        /// <summary>
        /// Перчатки.
        /// </summary>
        [Description("Перчатки")]
        Gloves = 6,

        /// <summary>
        /// Маска.
        /// </summary>
        [Description("Маска")]
        Mask = 7,

        /// <summary>
        /// Теплая одежда.
        /// </summary>
        [Description("Теплая одежда")]
        Warm = 8
    }
}
