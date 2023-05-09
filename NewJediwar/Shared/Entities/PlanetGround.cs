using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NewJediwar.Shared.Entities
{
    public class PlanetGround : IModelBase
    {
        [ReadOnly(true), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ReadOnly(true)]
        public DateTime CreatedAt { get; set; }

        [ReadOnly(true)]
        public DateTime UpdatedAt { get; set; }
        public int Column { get; set; }

        public int Row { get; set; }

        [Required]
        public Guid GroundEnvironmentId { get; set; }
        public GroundEnvironment GroundEnvironment { get; set; }


        [Required]
        public Guid PlanetId { get; set; }
        public Planet Planet { get; set; }

        public PlanetGround() { }

        public PlanetGround(int row, int column, GroundEnvironment environnment)
        {
            Column = column;
            Row = row;
            GroundEnvironment = environnment;
        }

        public string GetGroundColorHex()
        {
            return GroundEnvironment.GetColorHex();
        }
    }
}
