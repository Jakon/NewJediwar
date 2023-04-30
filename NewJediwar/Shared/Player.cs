namespace NewJediwar.Shared
{
    public class Player
    {
        public string Name { get; set; }

        public List<Character> Characters { get; set; } = new List<Character>();

        public Faction Faction { get; set; }
    }
}
