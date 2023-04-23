using System.ComponentModel;

namespace UniformAccountingSystem.Data.Entities
{
    public class Uniform
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public UniformType UniformType { get; set; } = UniformType.Other;

        public double Price { get; set; }

        public UniformTypeRef? UniformTypeRef { get; set; }
    }
}
