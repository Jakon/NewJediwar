using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NewJediwar.Shared.Entities
{
    public class GroundEnvironment : IModelBase
    {
        [ReadOnly(true), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ReadOnly(true)]
        public DateTime CreatedAt { get; set; }

        [ReadOnly(true)]
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }

        public string TextureName { get; set; }

        public bool IsPracticable { get; set; }

        public bool IsBuildable { get; set; }

        public string Color { get; set; }

        public GroundEnvironment() { }

        public string GetColorHex()
        {
            return $"#{Color}";
        }
    }
}
