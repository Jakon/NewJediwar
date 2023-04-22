namespace NewJediwar.Shared
{
    public class JediwarCharacter
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public int VisionScope { get; set; }
        public List<JediwarPower> Powers { get; set; }

        public JediwarCharacter(string name, int row, int column)
        {
            Name = name;
            X = row;
            Y = column;
            Powers = new List<JediwarPower>();
        }

        public JediwarCharacter(string name, int x, int y, int visionScope)
        {
            Name = name;
            X = x;
            Y = y;
            Powers = new List<JediwarPower>();
            VisionScope = visionScope;
        }
    }
}
