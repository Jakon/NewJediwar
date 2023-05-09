using NewJediwar.Shared.Entities;

namespace NewJediwar.Shared
{
    public static class InitGame
    {
        private static Dictionary<string, GroundEnvironment> _env;

        public static void InitGrid(Planet grid)
        {
            // On va créer les environnements
            InitEnvironnments();

            // On gère les personnages
            InitCharacters(grid);

            // On va gérer la grid
            InitCells(grid);
        }

        private static void InitCharacters(Planet grid)
        {
            // Ajout de personnages à la grille
            grid.Characters.Add(new Character("Jedi 2", 15, 5));
        }

        private static void InitEnvironnments()
        {
            _env = new Dictionary<string, GroundEnvironment>
            {
                {
                    "water",
                    new GroundEnvironment
                    {
                        Name = "Water",
                        TextureName = "eau.png",
                        IsBuildable = false,
                        IsPracticable = false,
                        Color = "00BFFF"
                    }
                },
                {
                    "grass",
                    new GroundEnvironment
                    {
                        Name = "Grass",
                        TextureName = "herbe.png",
                        IsBuildable = true,
                        IsPracticable = true,
                        Color = "7CB03D"
                    }
                },
                {
                    "dirt",
                    new GroundEnvironment
                    {
                        Name = "Dirt",
                        TextureName = "terre.png",
                        IsBuildable = true,
                        IsPracticable = true,
                        Color = "582900"
                    }
                },
                {
                    "city",
                    new GroundEnvironment
                    {
                        Name = "City",
                        TextureName = "ville.png",
                        IsBuildable = false,
                        IsPracticable = true,
                        Color = "FDEE00"
                    }
                },
                {
                    "jedi",
                    new GroundEnvironment
                    {
                        Name = "Jedi",
                        TextureName = "jedi.png",
                        IsBuildable = false,
                        IsPracticable = false,
                        Color = "AFAFAF"
                    }
                }
            };

        }

        //private static void InitCells(JediwarGrid grid)
        //{
        //    grid.Cells[0, 0] = new JediwarCell(0, 0, _env["grass"]));
        //    grid.Cells[0, 1] = new JediwarCell(0, 1, _env["grass"]));
        //    grid.Cells[0, 2] = new JediwarCell(0, 2, _env["dirt"]));
        //    grid.Cells[0, 3] = new JediwarCell(0, 3, _env["grass"]));
        //    grid.Cells[0, 4] = new JediwarCell(0, 4, _env["grass"]));

        //    grid.Cells[1, 0] = new JediwarCell(1, 0, _env["dirt"]));
        //    grid.Cells[1, 1] = new JediwarCell(1, 1, _env["dirt"]));
        //    grid.Cells[1, 2] = new JediwarCell(1, 2, _env["dirt"]));
        //    grid.Cells[1, 3] = new JediwarCell(1, 3, _env["dirt"]));
        //    grid.Cells[1, 4] = new JediwarCell(1, 4, _env["dirt"]));

        //    grid.Cells[2, 0] = new JediwarCell(2, 0, _env["grass"]));
        //    grid.Cells[2, 1] = new JediwarCell(2, 1, _env["grass"]));
        //    grid.Cells[2, 2] = new JediwarCell(2, 2, _env["dirt"]));
        //    grid.Cells[2, 3] = new JediwarCell(2, 3, _env["grass"]));
        //    grid.Cells[2, 4] = new JediwarCell(2, 4, _env["grass"]));

        //    grid.Cells[3, 0] = new JediwarCell(3, 0, _env["dirt"]));
        //    grid.Cells[3, 1] = new JediwarCell(3, 1, _env["dirt"]));
        //    grid.Cells[3, 2] = new JediwarCell(3, 2, _env["dirt"]));
        //    grid.Cells[3, 3] = new JediwarCell(3, 3, _env["dirt"]));
        //    grid.Cells[3, 4] = new JediwarCell(3, 4, _env["dirt"]));

        //    grid.Cells[4, 0] = new JediwarCell(4, 0, _env["grass"]));
        //    grid.Cells[4, 1] = new JediwarCell(4, 1, _env["grass"]));
        //    grid.Cells[4, 2] = new JediwarCell(4, 2, _env["dirt"]));
        //    grid.Cells[4, 3] = new JediwarCell(4, 3, _env["grass"]));
        //    grid.Cells[4, 4] = new JediwarCell(4, 4, _env["grass"]));

        //    grid.Cells[5, 0] = new JediwarCell(5, 0, _env["dirt"]));
        //    grid.Cells[5, 1] = new JediwarCell(5, 1, _env["dirt"]));
        //    grid.Cells[5, 2] = new JediwarCell(5, 2, _env["dirt"]));
        //    grid.Cells[5, 3] = new JediwarCell(5, 3, _env["dirt"]));
        //    grid.Cells[5, 4] = new JediwarCell(5, 4, _env["dirt"]));

        //    grid.Cells[6, 0] = new JediwarCell(6, 0, _env["grass"]));
        //    grid.Cells[6, 1] = new JediwarCell(6, 1, _env["grass"]));
        //    grid.Cells[6, 2] = new JediwarCell(6, 2, _env["dirt"]));
        //    grid.Cells[6, 3] = new JediwarCell(6, 3, _env["grass"]));
        //    grid.Cells[6, 4] = new JediwarCell(6, 4, _env["grass"]));

        //    grid.Cells[7, 0] = new JediwarCell(7, 0, _env["dirt"]));
        //    grid.Cells[7, 1] = new JediwarCell(7, 1, _env["dirt"]));
        //    grid.Cells[7, 2] = new JediwarCell(7, 2, _env["dirt"]));
        //    grid.Cells[7, 3] = new JediwarCell(7, 3, _env["dirt"]));
        //    grid.Cells[7, 4] = new JediwarCell(7, 4, _env["dirt"]));

        //    grid.Cells[8, 0] = new JediwarCell(8, 0, _env["grass"]));
        //    grid.Cells[8, 1] = new JediwarCell(8, 1, _env["grass"]));
        //    grid.Cells[8, 2] = new JediwarCell(8, 2, _env["dirt"]));
        //    grid.Cells[8, 3] = new JediwarCell(8, 3, _env["grass"]));
        //    grid.Cells[8, 4] = new JediwarCell(8, 4, _env["grass"]));

        //    grid.Cells[9, 0] = new JediwarCell(9, 0, _env["dirt"]));
        //    grid.Cells[9, 1] = new JediwarCell(9, 1, _env["dirt"]));
        //    grid.Cells[9, 2] = new JediwarCell(9, 2, _env["dirt"]));
        //    grid.Cells[9, 3] = new JediwarCell(9, 3, _env["dirt"]));
        //    grid.Cells[9, 4] = new JediwarCell(9, 4, _env["dirt"]));
        //}

        private static void InitCells(Planet grid)
        {
            #region Ligne 0
            // Ligne 0 
            grid.Cells.Add(new PlanetGround(0, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 9, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 10, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(0, 11, _env["water"]));
            grid.Cells.Add(new PlanetGround(0, 12, _env["water"]));
            grid.Cells.Add(new PlanetGround(0, 13, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(0, 14, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 15, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 16, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 17, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 18, _env["grass"]));
            grid.Cells.Add(new PlanetGround(0, 19, _env["grass"]));
            #endregion

            #region Ligne 1
            // Ligne 1
            grid.Cells.Add(new PlanetGround(1, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 9, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 10, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(1, 11, _env["water"]));
            grid.Cells.Add(new PlanetGround(1, 12, _env["water"]));
            grid.Cells.Add(new PlanetGround(1, 13, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(1, 14, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 15, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 16, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 17, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 18, _env["grass"]));
            grid.Cells.Add(new PlanetGround(1, 19, _env["grass"]));
            #endregion

            #region Ligne 2
            // Ligne 2 
            grid.Cells.Add(new PlanetGround(2, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(2, 10, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(2, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(2, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(2, 13, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(2, 14, _env["grass"]));
            grid.Cells.Add( new PlanetGround(2, 15, _env["grass"]));
            grid.Cells.Add( new PlanetGround(2, 16, _env["grass"]));
            grid.Cells.Add( new PlanetGround(2, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(2, 18, _env["grass"]));
            grid.Cells.Add(new PlanetGround(2, 19, _env["grass"]));
            #endregion

            #region Ligne 3
            // Ligne 3 
            grid.Cells.Add(new PlanetGround(3, 0, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(3, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(3, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(3, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(3, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(3, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(3, 6, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(3, 7, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(3, 8, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(3, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(3, 10, _env["water"]));
            grid.Cells.Add( new PlanetGround(3, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(3, 12, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(3, 13, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(3, 14, _env["grass"]));
            grid.Cells.Add( new PlanetGround(3, 15, _env["grass"]));
            grid.Cells.Add( new PlanetGround(3, 16, _env["grass"]));
            grid.Cells.Add( new PlanetGround(3, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(3, 18, _env["grass"]));
            grid.Cells.Add( new PlanetGround(3, 19, _env["dirt"]));
            #endregion

            #region Ligne 4
            // Ligne 4 
            grid.Cells.Add(new PlanetGround(4, 0, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(4, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(4, 2, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(4, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(4, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(4, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(4, 6, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(4, 7, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(4, 8, _env["water"]));
            grid.Cells.Add(new PlanetGround(4, 9, _env["water"]));
            grid.Cells.Add( new PlanetGround(4, 10, _env["water"]));
            grid.Cells.Add( new PlanetGround(4, 11, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(4, 12, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(4, 13, _env["grass"]));
            grid.Cells.Add( new PlanetGround(4, 14, _env["grass"]));
            grid.Cells.Add( new PlanetGround(4, 15, _env["grass"]));
            grid.Cells.Add( new PlanetGround(4, 16, _env["grass"]));
            grid.Cells.Add( new PlanetGround(4, 17, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(4, 18, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(4, 19, _env["dirt"]));
            #endregion

            #region Ligne 5
            // Ligne 5 
            grid.Cells.Add(new PlanetGround(5, 0, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(5, 1, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(5, 2, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(5, 3, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(5, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(5, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(5, 6, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(5, 7, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(5, 8, _env["water"]));
            grid.Cells.Add(new PlanetGround(5, 9, _env["water"]));
            grid.Cells.Add( new PlanetGround(5, 10, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(5, 11, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(5, 12, _env["grass"]));
            grid.Cells.Add( new PlanetGround(5, 13, _env["grass"]));
            grid.Cells.Add( new PlanetGround(5, 14, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(5, 15, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(5, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(5, 17, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(5, 18, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(5, 19, _env["dirt"]));
            #endregion

            #region Ligne 6
            // Ligne 6 
            grid.Cells.Add(new PlanetGround(6, 0, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(6, 1, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(6, 2, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(6, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(6, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(6, 5, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(6, 6, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(6, 7, _env["water"]));
            grid.Cells.Add(new PlanetGround(6, 8, _env["water"]));
            grid.Cells.Add(new PlanetGround(6, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(6, 10, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(6, 11, _env["grass"]));
            grid.Cells.Add( new PlanetGround(6, 12, _env["grass"]));
            grid.Cells.Add( new PlanetGround(6, 13, _env["grass"]));
            grid.Cells.Add( new PlanetGround(6, 14, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(6, 15, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(6, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(6, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(6, 18, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(6, 19, _env["dirt"]));
            #endregion

            #region Ligne 7
            // Ligne 7 
            grid.Cells.Add(new PlanetGround(7, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(7, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(7, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(7, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(7, 4, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(7, 5, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(7, 6, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(7, 7, _env["water"]));
            grid.Cells.Add(new PlanetGround(7, 8, _env["water"]));
            grid.Cells.Add(new PlanetGround(7, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(7, 10, _env["grass"]));
            grid.Cells.Add( new PlanetGround(7, 11, _env["grass"]));
            grid.Cells.Add( new PlanetGround(7, 12, _env["grass"]));
            grid.Cells.Add( new PlanetGround(7, 13, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(7, 14, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(7, 15, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(7, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(7, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(7, 18, _env["grass"]));
            grid.Cells.Add(new PlanetGround(7, 19, _env["grass"]));
            #endregion

            #region Ligne 8
            // Ligne 8 
            grid.Cells.Add(new PlanetGround(8, 0, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(8, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(8, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(8, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(8, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(8, 5, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(8, 6, _env["water"]));
            grid.Cells.Add(new PlanetGround(8, 7, _env["water"]));
            grid.Cells.Add(new PlanetGround(8, 8, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(8, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(8, 10, _env["grass"]));
            grid.Cells.Add( new PlanetGround(8, 11, _env["grass"]));
            grid.Cells.Add( new PlanetGround(8, 12, _env["grass"]));
            grid.Cells.Add( new PlanetGround(8, 13, _env["grass"]));
            grid.Cells.Add( new PlanetGround(8, 14, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(8, 15, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(8, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(8, 17, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(8, 18, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(8, 19, _env["dirt"]));
            #endregion

            #region Ligne 9
            // Ligne 9 
            grid.Cells.Add(new PlanetGround(9, 0, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(9, 1, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(9, 2, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(9, 3, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(9, 4, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(9, 5, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(9, 6, _env["water"]));
            grid.Cells.Add(new PlanetGround(9, 7, _env["water"]));
            grid.Cells.Add(new PlanetGround(9, 8, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(9, 9, _env["grass"]));
            grid.Cells.Add( new PlanetGround(9, 10, _env["grass"]));
            grid.Cells.Add( new PlanetGround(9, 11, _env["grass"]));
            grid.Cells.Add( new PlanetGround(9, 12, _env["grass"]));
            grid.Cells.Add( new PlanetGround(9, 13, _env["grass"]));
            grid.Cells.Add( new PlanetGround(9, 14, _env["grass"]));
            grid.Cells.Add( new PlanetGround(9, 15, _env["grass"]));
            grid.Cells.Add( new PlanetGround(9, 16, _env["grass"]));
            grid.Cells.Add( new PlanetGround(9, 17, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(9, 18, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(9, 19, _env["dirt"]));
            #endregion

            #region Ligne 10
            // Ligne 10
            grid.Cells.Add(new PlanetGround(10, 0, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(10, 1, _env["water"]));
            grid.Cells.Add(new PlanetGround(10, 2, _env["water"]));
            grid.Cells.Add(new PlanetGround(10, 3, _env["water"]));
            grid.Cells.Add(new PlanetGround(10, 4, _env["water"]));
            grid.Cells.Add(new PlanetGround(10, 5, _env["water"]));
            grid.Cells.Add(new PlanetGround(10, 6, _env["water"]));
            grid.Cells.Add(new PlanetGround(10, 7, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(10, 8, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(10, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(10, 10, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(10, 11, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(10, 12, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(10, 13, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(10, 14, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(10, 15, _env["grass"]));
            grid.Cells.Add( new PlanetGround(10, 16, _env["grass"]));
            grid.Cells.Add( new PlanetGround(10, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(10, 18, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(10, 19, _env["dirt"]));
            #endregion

            #region Ligne 11
            // Ligne 11 
            grid.Cells.Add(new PlanetGround(11, 0, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(11, 1, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(11, 2, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(11, 3, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(11, 4, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(11, 5, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(11, 6, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(11, 7, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(11, 8, _env["dirt"]));
            grid.Cells.Add(new PlanetGround(11, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(11, 10, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(11, 11, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(11, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(11, 13, _env["water"]));
            grid.Cells.Add( new PlanetGround(11, 14, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(11, 15, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(11, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(11, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(11, 18, _env["grass"]));
            grid.Cells.Add(new PlanetGround(11, 19, _env["dirt"]));
            #endregion

            #region Ligne 12
            // Ligne 12
            grid.Cells.Add(new PlanetGround(12, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(12, 10, _env["water"]));
            grid.Cells.Add( new PlanetGround(12, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(12, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(12, 13, _env["water"]));
            grid.Cells.Add( new PlanetGround(12, 14, _env["water"]));
            grid.Cells.Add( new PlanetGround(12, 15, _env["water"]));
            grid.Cells.Add( new PlanetGround(12, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(12, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(12, 18, _env["grass"]));
            grid.Cells.Add(new PlanetGround(12, 19, _env["grass"]));
            #endregion

            #region Ligne 13
            // Ligne 13 
            grid.Cells.Add(new PlanetGround(13, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(13, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(13, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(13, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(13, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(13, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(13, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(13, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(13, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(13, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(13, 10, _env["water"]));
            grid.Cells.Add( new PlanetGround(13, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(13, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(13, 13, _env["water"]));
            grid.Cells.Add( new PlanetGround(13, 14, _env["water"]));
            grid.Cells.Add( new PlanetGround(13, 15, _env["water"]));
            grid.Cells.Add( new PlanetGround(13, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(13, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(13, 18, _env["grass"]));
            grid.Cells.Add( new PlanetGround(13, 19, _env["grass"]));
            #endregion

            #region Ligne 14
            // Ligne 14 
            grid.Cells.Add(new PlanetGround(14, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(14, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(14, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(14, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(14, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(14, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(14, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(14, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(14, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(14, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(14, 10, _env["water"]));
            grid.Cells.Add( new PlanetGround(14, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(14, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(14, 13, _env["water"]));
            grid.Cells.Add( new PlanetGround(14, 14, _env["water"]));
            grid.Cells.Add( new PlanetGround(14, 15, _env["water"]));
            grid.Cells.Add( new PlanetGround(14, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(14, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(14, 18, _env["grass"]));
            grid.Cells.Add( new PlanetGround(14, 19, _env["grass"]));
            #endregion

            #region Ligne 15
            // Ligne 15 
            grid.Cells.Add(new PlanetGround(15, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(15, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(15, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(15, 3, _env["city"]));
            grid.Cells.Add(new PlanetGround(15, 4, _env["city"]));
            grid.Cells.Add(new PlanetGround(15, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(15, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(15, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(15, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(15, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(15, 10, _env["water"]));
            grid.Cells.Add( new PlanetGround(15, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(15, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(15, 13, _env["water"]));
            grid.Cells.Add( new PlanetGround(15, 14, _env["water"]));
            grid.Cells.Add( new PlanetGround(15, 15, _env["water"]));
            grid.Cells.Add( new PlanetGround(15, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(15, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(15, 18, _env["grass"]));
            grid.Cells.Add( new PlanetGround(15, 19, _env["grass"]));
            #endregion

            #region Ligne 16
            // Ligne 16 
            grid.Cells.Add(new PlanetGround(16, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(16, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(16, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(16, 3, _env["city"]));
            grid.Cells.Add(new PlanetGround(16, 4, _env["city"]));
            grid.Cells.Add(new PlanetGround(16, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(16, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(16, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(16, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(16, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(16, 10, _env["water"]));
            grid.Cells.Add( new PlanetGround(16, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(16, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(16, 13, _env["water"]));
            grid.Cells.Add( new PlanetGround(16, 14, _env["water"]));
            grid.Cells.Add( new PlanetGround(16, 15, _env["water"]));
            grid.Cells.Add( new PlanetGround(16, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(16, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(16, 18, _env["grass"]));
            grid.Cells.Add( new PlanetGround(16, 19, _env["grass"]));
            #endregion

            #region Ligne 17
            // Ligne 17 
            grid.Cells.Add(new PlanetGround(17, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(17, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(17, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(17, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(17, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(17, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(17, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(17, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(17, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(17, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(17, 10, _env["water"]));
            grid.Cells.Add( new PlanetGround(17, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(17, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(17, 13, _env["water"]));
            grid.Cells.Add( new PlanetGround(17, 14, _env["water"]));
            grid.Cells.Add( new PlanetGround(17, 15, _env["water"]));
            grid.Cells.Add( new PlanetGround(17, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(17, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(17, 18, _env["grass"]));
            grid.Cells.Add( new PlanetGround(17, 19, _env["grass"]));
            #endregion

            #region Ligne 18
            // Ligne 18 
            grid.Cells.Add(new PlanetGround(18, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(18, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(18, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(18, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(18, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(18, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(18, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(18, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(18, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(18, 9, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(18, 10, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(18, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(18, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(18, 13, _env["water"]));
            grid.Cells.Add( new PlanetGround(18, 14, _env["water"]));
            grid.Cells.Add( new PlanetGround(18, 15, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(18, 16, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(18, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(18, 18, _env["grass"]));
            grid.Cells.Add( new PlanetGround(18, 19, _env["grass"]));
            #endregion

            #region Ligne 19
            // Ligne 19 
            grid.Cells.Add(new PlanetGround(19, 0, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 1, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 2, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 3, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 4, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 5, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 6, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 7, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 8, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 9, _env["grass"]));
            grid.Cells.Add( new PlanetGround(19, 10, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(19, 11, _env["water"]));
            grid.Cells.Add( new PlanetGround(19, 12, _env["water"]));
            grid.Cells.Add( new PlanetGround(19, 13, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(19, 14, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(19, 15, _env["dirt"]));
            grid.Cells.Add( new PlanetGround(19, 16, _env["grass"]));
            grid.Cells.Add( new PlanetGround(19, 17, _env["grass"]));
            grid.Cells.Add( new PlanetGround(19, 18, _env["grass"]));
            grid.Cells.Add(new PlanetGround(19, 19, _env["grass"]));
            #endregion
        }
    }
}
