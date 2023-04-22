namespace NewJediwar.Shared
{
    public class JediwarCharacter
    {
        public string Name { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }

        public int VisionScope { get; set; }
        public List<JediwarPower> Powers { get; set; }

        public JediwarCharacter(string name, int row, int column)
        {
            Name = name;
            Column = column;
            Row = row;
            Powers = new List<JediwarPower>();
        }

        public JediwarCharacter(string name, int row, int column, int visionScope)
        {
            Name = name;
            Column = column;
            Row = row;
            Powers = new List<JediwarPower>();
            VisionScope = visionScope;
        }
    }
}
