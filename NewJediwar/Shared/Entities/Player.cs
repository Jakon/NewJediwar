using System.Text.Json.Serialization;

namespace NewJediwar.Shared.Entities
{
    public class Player
    {
        public Guid Id { get; set; }

        public string Login { get; set; }

        public string Name { get; set; } = string.Empty;

        //public List<Character> Characters { get; set; } = new List<Character>();

        //public Faction Faction { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }

    }
}
