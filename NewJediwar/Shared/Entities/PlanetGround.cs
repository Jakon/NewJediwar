namespace NewJediwar.Shared.Entities
{
    public class PlanetGround
    {
        public int Column { get; set; }

        public int Row { get; set; }

        public GroundEnvironment GroundEnvironment { get; set; }


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
