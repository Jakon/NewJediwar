namespace NewJediwar.Shared
{
    public class Character
    {
        public string Name { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }

        public int VisionScope { get; set; }
        public List<CharacterPower> Powers { get; set; }

        public Player Player { get; set; }

        public Character(string name, int row, int column)
        {
            Name = name;
            Column = column;
            Row = row;
            Powers = new List<CharacterPower>();
        }

        public Character(string name, int row, int column, int visionScope)
        {
            Name = name;
            Column = column;
            Row = row;
            Powers = new List<CharacterPower>();
            VisionScope = visionScope;
        }

        public string GetFactionColorHex()
        {
            //return Player.Faction.GetColorHex();
            return "#2BFAFA";
        }
    }
}
