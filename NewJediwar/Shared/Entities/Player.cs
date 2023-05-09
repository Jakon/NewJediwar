using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace NewJediwar.Shared.Entities
{
    public class Player : IModelBase
    {
        [ReadOnly(true), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ReadOnly(true)]
        public DateTime CreatedAt { get; set; }

        [ReadOnly(true)]
        public DateTime UpdatedAt { get; set; }

        public string Login { get; set; }

        public string Name { get; set; } = string.Empty;

        //public List<Character> Characters { get; set; } = new List<Character>();

        //public Faction Faction { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}
