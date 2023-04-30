namespace NewJediwar.Shared
{
    public class Faction
    {
        public string Name { get; set; }

        public int Color { get; set; }

        public string GetColorHex()
        {
            return $"#{Color}";
        }
    }
}
