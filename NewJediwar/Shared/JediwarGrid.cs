namespace NewJediwar.Shared
{
    public class JediwarGrid
    {
        public int Rows { get; set; }
        public int VisibleRows { get; set; }
        public int Columns { get; set; }
        public int VisibleColumns { get; set; }
        public int CellSize { get; set; }

        public JediwarCell[,] Cells { get; set; }

        public string CellSizeString => $"{CellSize}px";
        public List<JediwarCharacter> Characters { get; set; }

        public JediwarGrid(int rows, int columns, int cellSize)
        {
            Rows = rows;
            Columns = columns;
            CellSize = cellSize;
            Characters = new List<JediwarCharacter>();

            PopulateGrid();
        }

        private void PopulateGrid()
        {
            Cells = new JediwarCell[Rows, Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Cells[i, j] = new JediwarCell() { X = i, Y = j };
                }
            }
        }

        public List<JediwarCell> GetVisibleCells(JediwarCharacter playerCharacter)
        {
            var list = new List<JediwarCell>();

            // L'idée, c'est de calculer à l'aide d'une division euclidienne les coordonnées des cases addjacentes. 
            // On va de -Vision à +Vision
            for (var x = -playerCharacter.VisionScope; x <= playerCharacter.VisionScope; x++)
            {
                for (var y = -playerCharacter.VisionScope; y <= playerCharacter.VisionScope; y++)
                {
                    var xRelatif = (playerCharacter.X + x + Rows) % Rows;
                    var yRelatif = (playerCharacter.Y + y + Columns) % Columns;

                    list.Add(Cells[xRelatif, yRelatif]);
                }
            }

            // On update le nombre de cases visibles
            // TODO TROUVER UNE MEILLEURE PLACE
            VisibleRows = playerCharacter.VisionScope * 2 + 2;
            VisibleColumns = playerCharacter.VisionScope * 2 + 2;

            return list;
        }

        public void MoveCharacter(JediwarCharacter playerCharacter, int offsetX, int offsetY)
        {
            if (CanMove())
            {
                playerCharacter.X = (playerCharacter.X + offsetX + Rows) % Rows;
                playerCharacter.Y = (playerCharacter.Y + offsetY + Columns) % Columns;
            }
        }

        public bool CanMove()
        {
            return true;
        }

    }
}
