namespace NewJediwar.Shared
{
    public class Planet
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int CellSize { get; set; }
        public PlanetGround[,] Cells { get; set; }
        public List<Character> Characters { get; set; }

        public string Name { get; set; }

        public Planet(int rows, int columns, int cellSize, string name)
        {
            Rows = rows;
            Columns = columns;
            CellSize = cellSize;
            Characters = new List<Character>();
            Cells = new PlanetGround[Rows, Columns];
            Name = name;
        }

        //public List<JediwarCell> GetVisibleCells(JediwarCharacter playerCharacter)
        //{
        //    var list = new List<JediwarCell>();

        //    // L'idée, c'est de calculer à l'aide d'une division euclidienne les coordonnées des cases addjacentes. 
        //    // On va de -Vision à +Vision
        //    for (var col = -playerCharacter.VisionScope; col <= playerCharacter.VisionScope; col++)
        //    {
        //        for (var row = -playerCharacter.VisionScope; row <= playerCharacter.VisionScope; row++)
        //        {
        //            var colRelatif = (playerCharacter.Column + col + Columns) % Columns;
        //            var rowRelatif = (playerCharacter.Row + row + Rows) % Rows;

        //            list.Add(Cells[rowRelatif, colRelatif]);
        //        }
        //    }

        //    return list;
        //}

        public void MoveCharacter(Character playerCharacter, int rowOffset, int columnOffset)
        {
            // On calcule les nouvelles coordonnées
            var newColumn = (playerCharacter.Column + columnOffset + Columns) % Columns;
            var newRow = (playerCharacter.Row + rowOffset + Rows) % Rows;

            if (CanMove(newRow, newColumn))
            {
                playerCharacter.Column = newColumn;
                playerCharacter.Row = newRow;
            }
        }

        private bool CanMove(int row, int column)
        {
            // On vérifie que la case est praticable.
            var cell = Cells[row, column];

            if(cell.GroundEnvironment.IsPracticable)
            {
                // Si la case est praticable, on vérifie qu'elle n'est pas occupée
                var isCharacterPresentOnCell = Characters.Any(c => c.Row == row && c.Column == column);

                if(!isCharacterPresentOnCell)
                {
                    // On vérifie qu'il s'il y a une construction
                    return true;
                }
            }

            // Dans tous les autres cas, on ne peut pas se déplacer
            return false;
        }

    }
}
