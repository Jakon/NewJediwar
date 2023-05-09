using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NewJediwar.Shared.Entities
{
    public class Planet : IModelBase
    {
        [ReadOnly(true), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ReadOnly(true)]
        public DateTime CreatedAt { get; set; }

        [ReadOnly(true)]
        public DateTime UpdatedAt { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int CellSize { get; set; }

        
        public List<PlanetGround> Cells { get; set; } = new List<PlanetGround>();
        public List<Character> Characters { get; set; }

        public string Name { get; set; }

        public Planet(int rows, int columns, int cellSize, string name)
        {
            Rows = rows;
            Columns = columns;
            CellSize = cellSize;
            Characters = new List<Character>();
            Name = name;
        }

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
            var cell = Cells.GetPlanetGround(row, column);

            if (cell.GroundEnvironment.IsPracticable)
            {
                // Si la case est praticable, on vérifie qu'elle n'est pas occupée
                var isCharacterPresentOnCell = Characters.Any(c => c.Row == row && c.Column == column);

                if (!isCharacterPresentOnCell)
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
