namespace NewJediwar.Shared
{
    public class JediwarCell
    {
        public int Column { get; set; }

        public int Row { get; set; }

        public JediwarEnvironment Environnment { get; set; }


        public JediwarCell(int row, int column, JediwarEnvironment environnment)
        {
            Column = column;
            Row = row;
            Environnment = environnment;
        }
    }
}
