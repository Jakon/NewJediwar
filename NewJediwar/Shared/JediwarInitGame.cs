﻿namespace NewJediwar.Shared
{
    public static class JediwarInitGame
    {
        private static Dictionary<string, JediwarEnvironment> _env;

        public static void InitGrid(JediwarGrid grid)
        {
            // On va créer les environnements
            InitEnvironnments();

            // On gère les personnages
            InitCharacters(grid);

            // On va gérer la grid
            InitCells(grid);            
        }

        private static void InitCharacters(JediwarGrid grid)
        {
            // Ajout de personnages à la grille
            grid.Characters.Add(new JediwarCharacter("Jedi 2", 15, 5));
        }

        private static void InitEnvironnments()
        {
            _env = new Dictionary<string, JediwarEnvironment>
            {
                {
                    "water",
                    new JediwarEnvironment
                    {
                        Name = "Water",
                        TextureName = "eau.png",
                        IsBuildable = false,
                        IsPracticable = false
                    }
                },
                {
                    "grass",
                    new JediwarEnvironment
                    {
                        Name = "Grass",
                        TextureName = "herbe.png",
                        IsBuildable = true,
                        IsPracticable = true
                    }
                },
                {
                    "dirt",
                    new JediwarEnvironment
                    {
                        Name = "Dirt",
                        TextureName = "terre.png",
                        IsBuildable = true,
                        IsPracticable = true
                    }
                },
                {
                    "city",
                    new JediwarEnvironment
                    {
                        Name = "City",
                        TextureName = "ville.png",
                        IsBuildable = false,
                        IsPracticable = true
                    }
                },
                {
                    "jedi",
                    new JediwarEnvironment
                    {
                        Name = "Jedi",
                        TextureName = "jedi.png",
                        IsBuildable = false,
                        IsPracticable = false
                    }
                }
            };

        }

        //private static void InitCells(JediwarGrid grid)
        //{
        //    grid.Cells[0, 0] = new JediwarCell(0, 0, _env["grass"]);
        //    grid.Cells[0, 1] = new JediwarCell(0, 1, _env["grass"]);
        //    grid.Cells[0, 2] = new JediwarCell(0, 2, _env["dirt"]);
        //    grid.Cells[0, 3] = new JediwarCell(0, 3, _env["grass"]);
        //    grid.Cells[0, 4] = new JediwarCell(0, 4, _env["grass"]);

        //    grid.Cells[1, 0] = new JediwarCell(1, 0, _env["dirt"]);
        //    grid.Cells[1, 1] = new JediwarCell(1, 1, _env["dirt"]);
        //    grid.Cells[1, 2] = new JediwarCell(1, 2, _env["dirt"]);
        //    grid.Cells[1, 3] = new JediwarCell(1, 3, _env["dirt"]);
        //    grid.Cells[1, 4] = new JediwarCell(1, 4, _env["dirt"]);

        //    grid.Cells[2, 0] = new JediwarCell(2, 0, _env["grass"]);
        //    grid.Cells[2, 1] = new JediwarCell(2, 1, _env["grass"]);
        //    grid.Cells[2, 2] = new JediwarCell(2, 2, _env["dirt"]);
        //    grid.Cells[2, 3] = new JediwarCell(2, 3, _env["grass"]);
        //    grid.Cells[2, 4] = new JediwarCell(2, 4, _env["grass"]);

        //    grid.Cells[3, 0] = new JediwarCell(3, 0, _env["dirt"]);
        //    grid.Cells[3, 1] = new JediwarCell(3, 1, _env["dirt"]);
        //    grid.Cells[3, 2] = new JediwarCell(3, 2, _env["dirt"]);
        //    grid.Cells[3, 3] = new JediwarCell(3, 3, _env["dirt"]);
        //    grid.Cells[3, 4] = new JediwarCell(3, 4, _env["dirt"]);

        //    grid.Cells[4, 0] = new JediwarCell(4, 0, _env["grass"]);
        //    grid.Cells[4, 1] = new JediwarCell(4, 1, _env["grass"]);
        //    grid.Cells[4, 2] = new JediwarCell(4, 2, _env["dirt"]);
        //    grid.Cells[4, 3] = new JediwarCell(4, 3, _env["grass"]);
        //    grid.Cells[4, 4] = new JediwarCell(4, 4, _env["grass"]);

        //    grid.Cells[5, 0] = new JediwarCell(5, 0, _env["dirt"]);
        //    grid.Cells[5, 1] = new JediwarCell(5, 1, _env["dirt"]);
        //    grid.Cells[5, 2] = new JediwarCell(5, 2, _env["dirt"]);
        //    grid.Cells[5, 3] = new JediwarCell(5, 3, _env["dirt"]);
        //    grid.Cells[5, 4] = new JediwarCell(5, 4, _env["dirt"]);

        //    grid.Cells[6, 0] = new JediwarCell(6, 0, _env["grass"]);
        //    grid.Cells[6, 1] = new JediwarCell(6, 1, _env["grass"]);
        //    grid.Cells[6, 2] = new JediwarCell(6, 2, _env["dirt"]);
        //    grid.Cells[6, 3] = new JediwarCell(6, 3, _env["grass"]);
        //    grid.Cells[6, 4] = new JediwarCell(6, 4, _env["grass"]);

        //    grid.Cells[7, 0] = new JediwarCell(7, 0, _env["dirt"]);
        //    grid.Cells[7, 1] = new JediwarCell(7, 1, _env["dirt"]);
        //    grid.Cells[7, 2] = new JediwarCell(7, 2, _env["dirt"]);
        //    grid.Cells[7, 3] = new JediwarCell(7, 3, _env["dirt"]);
        //    grid.Cells[7, 4] = new JediwarCell(7, 4, _env["dirt"]);

        //    grid.Cells[8, 0] = new JediwarCell(8, 0, _env["grass"]);
        //    grid.Cells[8, 1] = new JediwarCell(8, 1, _env["grass"]);
        //    grid.Cells[8, 2] = new JediwarCell(8, 2, _env["dirt"]);
        //    grid.Cells[8, 3] = new JediwarCell(8, 3, _env["grass"]);
        //    grid.Cells[8, 4] = new JediwarCell(8, 4, _env["grass"]);

        //    grid.Cells[9, 0] = new JediwarCell(9, 0, _env["dirt"]);
        //    grid.Cells[9, 1] = new JediwarCell(9, 1, _env["dirt"]);
        //    grid.Cells[9, 2] = new JediwarCell(9, 2, _env["dirt"]);
        //    grid.Cells[9, 3] = new JediwarCell(9, 3, _env["dirt"]);
        //    grid.Cells[9, 4] = new JediwarCell(9, 4, _env["dirt"]);
        //}

        private static void InitCells(JediwarGrid grid)
        {
            #region Ligne 0
            // Ligne 0 
            grid.Cells[0, 0] = new JediwarCell(0, 0, _env["grass"]);
            grid.Cells[0, 1] = new JediwarCell(0, 1, _env["grass"]);
            grid.Cells[0, 2] = new JediwarCell(0, 2, _env["grass"]);
            grid.Cells[0, 3] = new JediwarCell(0, 3, _env["grass"]);
            grid.Cells[0, 4] = new JediwarCell(0, 4, _env["grass"]);
            grid.Cells[0, 5] = new JediwarCell(0, 5, _env["grass"]);
            grid.Cells[0, 6] = new JediwarCell(0, 6, _env["grass"]);
            grid.Cells[0, 7] = new JediwarCell(0, 7, _env["grass"]);
            grid.Cells[0, 8] = new JediwarCell(0, 8, _env["grass"]);
            grid.Cells[0, 9] = new JediwarCell(0, 9, _env["grass"]);
            grid.Cells[0, 10] = new JediwarCell(0, 10, _env["dirt"]);
            grid.Cells[0, 11] = new JediwarCell(0, 11, _env["water"]);
            grid.Cells[0, 12] = new JediwarCell(0, 12, _env["water"]);
            grid.Cells[0, 13] = new JediwarCell(0, 13, _env["dirt"]);
            grid.Cells[0, 14] = new JediwarCell(0, 14, _env["grass"]);
            grid.Cells[0, 15] = new JediwarCell(0, 15, _env["grass"]);
            grid.Cells[0, 16] = new JediwarCell(0, 16, _env["grass"]);
            grid.Cells[0, 17] = new JediwarCell(0, 17, _env["grass"]);
            grid.Cells[0, 18] = new JediwarCell(0, 18, _env["grass"]);
            grid.Cells[0, 19] = new JediwarCell(0, 19, _env["grass"]);
            #endregion

            #region Ligne 1
            // Ligne 1
            grid.Cells[1, 0] = new JediwarCell(1, 0, _env["grass"]);
            grid.Cells[1, 1] = new JediwarCell(1, 1, _env["grass"]);
            grid.Cells[1, 2] = new JediwarCell(1, 2, _env["grass"]);
            grid.Cells[1, 3] = new JediwarCell(1, 3, _env["grass"]);
            grid.Cells[1, 4] = new JediwarCell(1, 4, _env["grass"]);
            grid.Cells[1, 5] = new JediwarCell(1, 5, _env["grass"]);
            grid.Cells[1, 6] = new JediwarCell(1, 6, _env["grass"]);
            grid.Cells[1, 7] = new JediwarCell(1, 7, _env["grass"]);
            grid.Cells[1, 8] = new JediwarCell(1, 8, _env["grass"]);
            grid.Cells[1, 9] = new JediwarCell(1, 9, _env["grass"]);
            grid.Cells[1, 10] = new JediwarCell(1, 10, _env["dirt"]);
            grid.Cells[1, 11] = new JediwarCell(1, 11, _env["water"]);
            grid.Cells[1, 12] = new JediwarCell(1, 12, _env["water"]);
            grid.Cells[1, 13] = new JediwarCell(1, 13, _env["dirt"]);
            grid.Cells[1, 14] = new JediwarCell(1, 14, _env["grass"]);
            grid.Cells[1, 15] = new JediwarCell(1, 15, _env["grass"]);
            grid.Cells[1, 16] = new JediwarCell(1, 16, _env["grass"]);
            grid.Cells[1, 17] = new JediwarCell(1, 17, _env["grass"]);
            grid.Cells[1, 18] = new JediwarCell(1, 18, _env["grass"]);
            grid.Cells[1, 19] = new JediwarCell(1, 19, _env["grass"]);
            #endregion

            #region Ligne 2
            // Ligne 2 
            grid.Cells[2, 0] = new JediwarCell(2, 0, _env["grass"]);
            grid.Cells[2, 1] = new JediwarCell(2, 1, _env["grass"]);
            grid.Cells[2, 2] = new JediwarCell(2, 2, _env["grass"]);
            grid.Cells[2, 3] = new JediwarCell(2, 3, _env["grass"]);
            grid.Cells[2, 4] = new JediwarCell(2, 4, _env["grass"]);
            grid.Cells[2, 5] = new JediwarCell(2, 5, _env["grass"]);
            grid.Cells[2, 6] = new JediwarCell(2, 6, _env["grass"]);
            grid.Cells[2, 7] = new JediwarCell(2, 7, _env["grass"]);
            grid.Cells[2, 8] = new JediwarCell(2, 8, _env["grass"]);
            grid.Cells[2, 9] = new JediwarCell(2, 9, _env["dirt"]);
            grid.Cells[2, 10] = new JediwarCell(2, 10, _env["dirt"]);
            grid.Cells[2, 11] = new JediwarCell(2, 11, _env["water"]);
            grid.Cells[2, 12] = new JediwarCell(2, 12, _env["water"]);
            grid.Cells[2, 13] = new JediwarCell(2, 13, _env["dirt"]);
            grid.Cells[2, 14] = new JediwarCell(2, 14, _env["grass"]);
            grid.Cells[2, 15] = new JediwarCell(2, 15, _env["grass"]);
            grid.Cells[2, 16] = new JediwarCell(2, 16, _env["grass"]);
            grid.Cells[2, 17] = new JediwarCell(2, 17, _env["grass"]);
            grid.Cells[2, 18] = new JediwarCell(2, 18, _env["grass"]);
            grid.Cells[2, 19] = new JediwarCell(2, 19, _env["grass"]);
            #endregion

            #region Ligne 3
            // Ligne 3 
            grid.Cells[3, 0] = new JediwarCell(3, 0, _env["dirt"]);
            grid.Cells[3, 1] = new JediwarCell(3, 1, _env["grass"]);
            grid.Cells[3, 2] = new JediwarCell(3, 2, _env["grass"]);
            grid.Cells[3, 3] = new JediwarCell(3, 3, _env["grass"]);
            grid.Cells[3, 4] = new JediwarCell(3, 4, _env["grass"]);
            grid.Cells[3, 5] = new JediwarCell(3, 5, _env["grass"]);
            grid.Cells[3, 6] = new JediwarCell(3, 6, _env["dirt"]);
            grid.Cells[3, 7] = new JediwarCell(3, 7, _env["dirt"]);
            grid.Cells[3, 8] = new JediwarCell(3, 8, _env["dirt"]);
            grid.Cells[3, 9] = new JediwarCell(3, 9, _env["dirt"]);
            grid.Cells[3, 10] = new JediwarCell(3, 10, _env["water"]);
            grid.Cells[3, 11] = new JediwarCell(3, 11, _env["water"]);
            grid.Cells[3, 12] = new JediwarCell(3, 12, _env["dirt"]);
            grid.Cells[3, 13] = new JediwarCell(3, 13, _env["dirt"]);
            grid.Cells[3, 14] = new JediwarCell(3, 14, _env["grass"]);
            grid.Cells[3, 15] = new JediwarCell(3, 15, _env["grass"]);
            grid.Cells[3, 16] = new JediwarCell(3, 16, _env["grass"]);
            grid.Cells[3, 17] = new JediwarCell(3, 17, _env["grass"]);
            grid.Cells[3, 18] = new JediwarCell(3, 18, _env["grass"]);
            grid.Cells[3, 19] = new JediwarCell(3, 19, _env["dirt"]);
            #endregion

            #region Ligne 4
            // Ligne 4 
            grid.Cells[4, 0] = new JediwarCell(4, 0, _env["dirt"]);
            grid.Cells[4, 1] = new JediwarCell(4, 1, _env["grass"]);
            grid.Cells[4, 2] = new JediwarCell(4, 2, _env["dirt"]);
            grid.Cells[4, 3] = new JediwarCell(4, 3, _env["grass"]);
            grid.Cells[4, 4] = new JediwarCell(4, 4, _env["grass"]);
            grid.Cells[4, 5] = new JediwarCell(4, 5, _env["grass"]);
            grid.Cells[4, 6] = new JediwarCell(4, 6, _env["dirt"]);
            grid.Cells[4, 7] = new JediwarCell(4, 7, _env["dirt"]);
            grid.Cells[4, 8] = new JediwarCell(4, 8, _env["water"]);
            grid.Cells[4, 9] = new JediwarCell(4, 9, _env["water"]);
            grid.Cells[4, 10] = new JediwarCell(4, 10, _env["water"]);
            grid.Cells[4, 11] = new JediwarCell(4, 11, _env["dirt"]);
            grid.Cells[4, 12] = new JediwarCell(4, 12, _env["dirt"]);
            grid.Cells[4, 13] = new JediwarCell(4, 13, _env["grass"]);
            grid.Cells[4, 14] = new JediwarCell(4, 14, _env["grass"]);
            grid.Cells[4, 15] = new JediwarCell(4, 15, _env["grass"]);
            grid.Cells[4, 16] = new JediwarCell(4, 16, _env["grass"]);
            grid.Cells[4, 17] = new JediwarCell(4, 17, _env["dirt"]);
            grid.Cells[4, 18] = new JediwarCell(4, 18, _env["dirt"]);
            grid.Cells[4, 19] = new JediwarCell(4, 19, _env["dirt"]);
            #endregion

            #region Ligne 5
            // Ligne 5 
            grid.Cells[5, 0] = new JediwarCell(5, 0, _env["dirt"]);
            grid.Cells[5, 1] = new JediwarCell(5, 1, _env["dirt"]);
            grid.Cells[5, 2] = new JediwarCell(5, 2, _env["dirt"]);
            grid.Cells[5, 3] = new JediwarCell(5, 3, _env["dirt"]);
            grid.Cells[5, 4] = new JediwarCell(5, 4, _env["grass"]);
            grid.Cells[5, 5] = new JediwarCell(5, 5, _env["grass"]);
            grid.Cells[5, 6] = new JediwarCell(5, 6, _env["dirt"]);
            grid.Cells[5, 7] = new JediwarCell(5, 7, _env["dirt"]);
            grid.Cells[5, 8] = new JediwarCell(5, 8, _env["water"]);
            grid.Cells[5, 9] = new JediwarCell(5, 9, _env["water"]);
            grid.Cells[5, 10] = new JediwarCell(5, 10, _env["dirt"]);
            grid.Cells[5, 11] = new JediwarCell(5, 11, _env["dirt"]);
            grid.Cells[5, 12] = new JediwarCell(5, 12, _env["grass"]);
            grid.Cells[5, 13] = new JediwarCell(5, 13, _env["grass"]);
            grid.Cells[5, 14] = new JediwarCell(5, 14, _env["dirt"]);
            grid.Cells[5, 15] = new JediwarCell(5, 15, _env["dirt"]);
            grid.Cells[5, 16] = new JediwarCell(5, 16, _env["dirt"]);
            grid.Cells[5, 17] = new JediwarCell(5, 17, _env["dirt"]);
            grid.Cells[5, 18] = new JediwarCell(5, 18, _env["dirt"]);
            grid.Cells[5, 19] = new JediwarCell(5, 19, _env["dirt"]);
            #endregion

            #region Ligne 6
            // Ligne 6 
            grid.Cells[6, 0] = new JediwarCell(6, 0, _env["dirt"]);
            grid.Cells[6, 1] = new JediwarCell(6, 1, _env["dirt"]);
            grid.Cells[6, 2] = new JediwarCell(6, 2, _env["dirt"]);
            grid.Cells[6, 3] = new JediwarCell(6, 3, _env["grass"]);
            grid.Cells[6, 4] = new JediwarCell(6, 4, _env["grass"]);
            grid.Cells[6, 5] = new JediwarCell(6, 5, _env["dirt"]);
            grid.Cells[6, 6] = new JediwarCell(6, 6, _env["dirt"]);
            grid.Cells[6, 7] = new JediwarCell(6, 7, _env["water"]);
            grid.Cells[6, 8] = new JediwarCell(6, 8, _env["water"]);
            grid.Cells[6, 9] = new JediwarCell(6, 9, _env["dirt"]);
            grid.Cells[6, 10] = new JediwarCell(6, 10, _env["dirt"]);
            grid.Cells[6, 11] = new JediwarCell(6, 11, _env["grass"]);
            grid.Cells[6, 12] = new JediwarCell(6, 12, _env["grass"]);
            grid.Cells[6, 13] = new JediwarCell(6, 13, _env["grass"]);
            grid.Cells[6, 14] = new JediwarCell(6, 14, _env["dirt"]);
            grid.Cells[6, 15] = new JediwarCell(6, 15, _env["dirt"]);
            grid.Cells[6, 16] = new JediwarCell(6, 16, _env["dirt"]);
            grid.Cells[6, 17] = new JediwarCell(6, 17, _env["grass"]);
            grid.Cells[6, 18] = new JediwarCell(6, 18, _env["dirt"]);
            grid.Cells[6, 19] = new JediwarCell(6, 19, _env["dirt"]);
            #endregion

            #region Ligne 7
            // Ligne 7 
            grid.Cells[7, 0] = new JediwarCell(7, 0, _env["grass"]);
            grid.Cells[7, 1] = new JediwarCell(7, 1, _env["grass"]);
            grid.Cells[7, 2] = new JediwarCell(7, 2, _env["grass"]);
            grid.Cells[7, 3] = new JediwarCell(7, 3, _env["grass"]);
            grid.Cells[7, 4] = new JediwarCell(7, 4, _env["dirt"]);
            grid.Cells[7, 5] = new JediwarCell(7, 5, _env["dirt"]);
            grid.Cells[7, 6] = new JediwarCell(7, 6, _env["dirt"]);
            grid.Cells[7, 7] = new JediwarCell(7, 7, _env["water"]);
            grid.Cells[7, 8] = new JediwarCell(7, 8, _env["water"]);
            grid.Cells[7, 9] = new JediwarCell(7, 9, _env["dirt"]);
            grid.Cells[7, 10] = new JediwarCell(7, 10, _env["grass"]);
            grid.Cells[7, 11] = new JediwarCell(7, 11, _env["grass"]);
            grid.Cells[7, 12] = new JediwarCell(7, 12, _env["grass"]);
            grid.Cells[7, 13] = new JediwarCell(7, 13, _env["dirt"]);
            grid.Cells[7, 14] = new JediwarCell(7, 14, _env["dirt"]);
            grid.Cells[7, 15] = new JediwarCell(7, 15, _env["dirt"]);
            grid.Cells[7, 16] = new JediwarCell(7, 16, _env["dirt"]);
            grid.Cells[7, 17] = new JediwarCell(7, 17, _env["grass"]);
            grid.Cells[7, 18] = new JediwarCell(7, 18, _env["grass"]);
            grid.Cells[7, 19] = new JediwarCell(7, 19, _env["grass"]);
            #endregion

            #region Ligne 8
            // Ligne 8 
            grid.Cells[8, 0] = new JediwarCell(8, 0, _env["dirt"]);
            grid.Cells[8, 1] = new JediwarCell(8, 1, _env["grass"]);
            grid.Cells[8, 2] = new JediwarCell(8, 2, _env["grass"]);
            grid.Cells[8, 3] = new JediwarCell(8, 3, _env["grass"]);
            grid.Cells[8, 4] = new JediwarCell(8, 4, _env["grass"]);
            grid.Cells[8, 5] = new JediwarCell(8, 5, _env["dirt"]);
            grid.Cells[8, 6] = new JediwarCell(8, 6, _env["water"]);
            grid.Cells[8, 7] = new JediwarCell(8, 7, _env["water"]);
            grid.Cells[8, 8] = new JediwarCell(8, 8, _env["dirt"]);
            grid.Cells[8, 9] = new JediwarCell(8, 9, _env["dirt"]);
            grid.Cells[8, 10] = new JediwarCell(8, 10, _env["grass"]);
            grid.Cells[8, 11] = new JediwarCell(8, 11, _env["grass"]);
            grid.Cells[8, 12] = new JediwarCell(8, 12, _env["grass"]);
            grid.Cells[8, 13] = new JediwarCell(8, 13, _env["grass"]);
            grid.Cells[8, 14] = new JediwarCell(8, 14, _env["dirt"]);
            grid.Cells[8, 15] = new JediwarCell(8, 15, _env["dirt"]);
            grid.Cells[8, 16] = new JediwarCell(8, 16, _env["dirt"]);
            grid.Cells[8, 17] = new JediwarCell(8, 17, _env["dirt"]);
            grid.Cells[8, 18] = new JediwarCell(8, 18, _env["dirt"]);
            grid.Cells[8, 19] = new JediwarCell(8, 19, _env["dirt"]);
            #endregion

            #region Ligne 9
            // Ligne 9 
            grid.Cells[9, 0] = new JediwarCell(9, 0, _env["dirt"]);
            grid.Cells[9, 1] = new JediwarCell(9, 1, _env["dirt"]);
            grid.Cells[9, 2] = new JediwarCell(9, 2, _env["dirt"]);
            grid.Cells[9, 3] = new JediwarCell(9, 3, _env["dirt"]);
            grid.Cells[9, 4] = new JediwarCell(9, 4, _env["dirt"]);
            grid.Cells[9, 5] = new JediwarCell(9, 5, _env["dirt"]);
            grid.Cells[9, 6] = new JediwarCell(9, 6, _env["water"]);
            grid.Cells[9, 7] = new JediwarCell(9, 7, _env["water"]);
            grid.Cells[9, 8] = new JediwarCell(9, 8, _env["dirt"]);
            grid.Cells[9, 9] = new JediwarCell(9, 9, _env["grass"]);
            grid.Cells[9, 10] = new JediwarCell(9, 10, _env["grass"]);
            grid.Cells[9, 11] = new JediwarCell(9, 11, _env["grass"]);
            grid.Cells[9, 12] = new JediwarCell(9, 12, _env["grass"]);
            grid.Cells[9, 13] = new JediwarCell(9, 13, _env["grass"]);
            grid.Cells[9, 14] = new JediwarCell(9, 14, _env["grass"]);
            grid.Cells[9, 15] = new JediwarCell(9, 15, _env["grass"]);
            grid.Cells[9, 16] = new JediwarCell(9, 16, _env["grass"]);
            grid.Cells[9, 17] = new JediwarCell(9, 17, _env["dirt"]);
            grid.Cells[9, 18] = new JediwarCell(9, 18, _env["dirt"]);
            grid.Cells[9, 19] = new JediwarCell(9, 19, _env["dirt"]);
            #endregion

            #region Ligne 10
            // Ligne 10
            grid.Cells[10, 0] = new JediwarCell(10, 0, _env["dirt"]);
            grid.Cells[10, 1] = new JediwarCell(10, 1, _env["water"]);
            grid.Cells[10, 2] = new JediwarCell(10, 2, _env["water"]);
            grid.Cells[10, 3] = new JediwarCell(10, 3, _env["water"]);
            grid.Cells[10, 4] = new JediwarCell(10, 4, _env["water"]);
            grid.Cells[10, 5] = new JediwarCell(10, 5, _env["water"]);
            grid.Cells[10, 6] = new JediwarCell(10, 6, _env["water"]);
            grid.Cells[10, 7] = new JediwarCell(10, 7, _env["dirt"]);
            grid.Cells[10, 8] = new JediwarCell(10, 8, _env["dirt"]);
            grid.Cells[10, 9] = new JediwarCell(10, 9, _env["dirt"]);
            grid.Cells[10, 10] = new JediwarCell(10, 10, _env["dirt"]);
            grid.Cells[10, 11] = new JediwarCell(10, 11, _env["dirt"]);
            grid.Cells[10, 12] = new JediwarCell(10, 12, _env["dirt"]);
            grid.Cells[10, 13] = new JediwarCell(10, 13, _env["dirt"]);
            grid.Cells[10, 14] = new JediwarCell(10, 14, _env["dirt"]);
            grid.Cells[10, 15] = new JediwarCell(10, 15, _env["grass"]);
            grid.Cells[10, 16] = new JediwarCell(10, 16, _env["grass"]);
            grid.Cells[10, 17] = new JediwarCell(10, 17, _env["grass"]);
            grid.Cells[10, 18] = new JediwarCell(10, 18, _env["dirt"]);
            grid.Cells[10, 19] = new JediwarCell(10, 19, _env["dirt"]);
            #endregion

            #region Ligne 11
            // Ligne 11 
            grid.Cells[11, 0] = new JediwarCell(11, 0, _env["dirt"]);
            grid.Cells[11, 1] = new JediwarCell(11, 1, _env["dirt"]);
            grid.Cells[11, 2] = new JediwarCell(11, 2, _env["dirt"]);
            grid.Cells[11, 3] = new JediwarCell(11, 3, _env["dirt"]);
            grid.Cells[11, 4] = new JediwarCell(11, 4, _env["dirt"]);
            grid.Cells[11, 5] = new JediwarCell(11, 5, _env["dirt"]);
            grid.Cells[11, 6] = new JediwarCell(11, 6, _env["dirt"]);
            grid.Cells[11, 7] = new JediwarCell(11, 7, _env["dirt"]);
            grid.Cells[11, 8] = new JediwarCell(11, 8, _env["dirt"]);
            grid.Cells[11, 9] = new JediwarCell(11, 9, _env["dirt"]);
            grid.Cells[11, 10] = new JediwarCell(11, 10, _env["dirt"]);
            grid.Cells[11, 11] = new JediwarCell(11, 11, _env["dirt"]);
            grid.Cells[11, 12] = new JediwarCell(11, 12, _env["water"]);
            grid.Cells[11, 13] = new JediwarCell(11, 13, _env["water"]);
            grid.Cells[11, 14] = new JediwarCell(11, 14, _env["dirt"]);
            grid.Cells[11, 15] = new JediwarCell(11, 15, _env["dirt"]);
            grid.Cells[11, 16] = new JediwarCell(11, 16, _env["dirt"]);
            grid.Cells[11, 17] = new JediwarCell(11, 17, _env["grass"]);
            grid.Cells[11, 18] = new JediwarCell(11, 18, _env["grass"]);
            grid.Cells[11, 19] = new JediwarCell(11, 19, _env["dirt"]);
            #endregion

            #region Ligne 12
            // Ligne 12
            grid.Cells[12, 0] = new JediwarCell(12, 0, _env["grass"]);
            grid.Cells[12, 1] = new JediwarCell(12, 1, _env["grass"]);
            grid.Cells[12, 2] = new JediwarCell(12, 2, _env["grass"]);
            grid.Cells[12, 3] = new JediwarCell(12, 3, _env["grass"]);
            grid.Cells[12, 4] = new JediwarCell(12, 4, _env["grass"]);
            grid.Cells[12, 5] = new JediwarCell(12, 5, _env["grass"]);
            grid.Cells[12, 6] = new JediwarCell(12, 6, _env["grass"]);
            grid.Cells[12, 7] = new JediwarCell(12, 7, _env["grass"]);
            grid.Cells[12, 8] = new JediwarCell(12, 8, _env["grass"]);
            grid.Cells[12, 9] = new JediwarCell(12, 9, _env["dirt"]);
            grid.Cells[12, 10] = new JediwarCell(12, 10, _env["water"]);
            grid.Cells[12, 11] = new JediwarCell(12, 11, _env["water"]);
            grid.Cells[12, 12] = new JediwarCell(12, 12, _env["water"]);
            grid.Cells[12, 13] = new JediwarCell(12, 13, _env["water"]);
            grid.Cells[12, 14] = new JediwarCell(12, 14, _env["water"]);
            grid.Cells[12, 15] = new JediwarCell(12, 15, _env["water"]);
            grid.Cells[12, 16] = new JediwarCell(12, 16, _env["dirt"]);
            grid.Cells[12, 17] = new JediwarCell(12, 17, _env["grass"]);
            grid.Cells[12, 18] = new JediwarCell(12, 18, _env["grass"]);
            grid.Cells[12, 19] = new JediwarCell(12, 19, _env["grass"]);
            #endregion

            #region Ligne 13
            // Ligne 13 
            grid.Cells[13, 0] = new JediwarCell(13, 0, _env["grass"]);
            grid.Cells[13, 1] = new JediwarCell(13, 1, _env["grass"]);
            grid.Cells[13, 2] = new JediwarCell(13, 2, _env["grass"]);
            grid.Cells[13, 3] = new JediwarCell(13, 3, _env["grass"]);
            grid.Cells[13, 4] = new JediwarCell(13, 4, _env["grass"]);
            grid.Cells[13, 5] = new JediwarCell(13, 5, _env["grass"]);
            grid.Cells[13, 6] = new JediwarCell(13, 6, _env["grass"]);
            grid.Cells[13, 7] = new JediwarCell(13, 7, _env["grass"]);
            grid.Cells[13, 8] = new JediwarCell(13, 8, _env["grass"]);
            grid.Cells[13, 9] = new JediwarCell(13, 9, _env["dirt"]);
            grid.Cells[13, 10] = new JediwarCell(13, 10, _env["water"]);
            grid.Cells[13, 11] = new JediwarCell(13, 11, _env["water"]);
            grid.Cells[13, 12] = new JediwarCell(13, 12, _env["water"]);
            grid.Cells[13, 13] = new JediwarCell(13, 13, _env["water"]);
            grid.Cells[13, 14] = new JediwarCell(13, 14, _env["water"]);
            grid.Cells[13, 15] = new JediwarCell(13, 15, _env["water"]);
            grid.Cells[13, 16] = new JediwarCell(13, 16, _env["dirt"]);
            grid.Cells[13, 17] = new JediwarCell(13, 17, _env["grass"]);
            grid.Cells[13, 18] = new JediwarCell(13, 18, _env["grass"]);
            grid.Cells[13, 19] = new JediwarCell(13, 19, _env["grass"]);
            #endregion

            #region Ligne 14
            // Ligne 14 
            grid.Cells[14, 0] = new JediwarCell(14, 0, _env["grass"]);
            grid.Cells[14, 1] = new JediwarCell(14, 1, _env["grass"]);
            grid.Cells[14, 2] = new JediwarCell(14, 2, _env["grass"]);
            grid.Cells[14, 3] = new JediwarCell(14, 3, _env["grass"]);
            grid.Cells[14, 4] = new JediwarCell(14, 4, _env["grass"]);
            grid.Cells[14, 5] = new JediwarCell(14, 5, _env["grass"]);
            grid.Cells[14, 6] = new JediwarCell(14, 6, _env["grass"]);
            grid.Cells[14, 7] = new JediwarCell(14, 7, _env["grass"]);
            grid.Cells[14, 8] = new JediwarCell(14, 8, _env["grass"]);
            grid.Cells[14, 9] = new JediwarCell(14, 9, _env["dirt"]);
            grid.Cells[14, 10] = new JediwarCell(14, 10, _env["water"]);
            grid.Cells[14, 11] = new JediwarCell(14, 11, _env["water"]);
            grid.Cells[14, 12] = new JediwarCell(14, 12, _env["water"]);
            grid.Cells[14, 13] = new JediwarCell(14, 13, _env["water"]);
            grid.Cells[14, 14] = new JediwarCell(14, 14, _env["water"]);
            grid.Cells[14, 15] = new JediwarCell(14, 15, _env["water"]);
            grid.Cells[14, 16] = new JediwarCell(14, 16, _env["dirt"]);
            grid.Cells[14, 17] = new JediwarCell(14, 17, _env["grass"]);
            grid.Cells[14, 18] = new JediwarCell(14, 18, _env["grass"]);
            grid.Cells[14, 19] = new JediwarCell(14, 19, _env["grass"]);
            #endregion

            #region Ligne 15
            // Ligne 15 
            grid.Cells[15, 0] = new JediwarCell(15, 0, _env["grass"]);
            grid.Cells[15, 1] = new JediwarCell(15, 1, _env["grass"]);
            grid.Cells[15, 2] = new JediwarCell(15, 2, _env["grass"]);
            grid.Cells[15, 3] = new JediwarCell(15, 3, _env["city"]);
            grid.Cells[15, 4] = new JediwarCell(15, 4, _env["city"]);
            grid.Cells[15, 5] = new JediwarCell(15, 5, _env["grass"]);
            grid.Cells[15, 6] = new JediwarCell(15, 6, _env["grass"]);
            grid.Cells[15, 7] = new JediwarCell(15, 7, _env["grass"]);
            grid.Cells[15, 8] = new JediwarCell(15, 8, _env["grass"]);
            grid.Cells[15, 9] = new JediwarCell(15, 9, _env["dirt"]);
            grid.Cells[15, 10] = new JediwarCell(15, 10, _env["water"]);
            grid.Cells[15, 11] = new JediwarCell(15, 11, _env["water"]);
            grid.Cells[15, 12] = new JediwarCell(15, 12, _env["water"]);
            grid.Cells[15, 13] = new JediwarCell(15, 13, _env["water"]);
            grid.Cells[15, 14] = new JediwarCell(15, 14, _env["water"]);
            grid.Cells[15, 15] = new JediwarCell(15, 15, _env["water"]);
            grid.Cells[15, 16] = new JediwarCell(15, 16, _env["dirt"]);
            grid.Cells[15, 17] = new JediwarCell(15, 17, _env["grass"]);
            grid.Cells[15, 18] = new JediwarCell(15, 18, _env["grass"]);
            grid.Cells[15, 19] = new JediwarCell(15, 19, _env["grass"]);
            #endregion

            #region Ligne 16
            // Ligne 16 
            grid.Cells[16, 0] = new JediwarCell(16, 0, _env["grass"]);
            grid.Cells[16, 1] = new JediwarCell(16, 1, _env["grass"]);
            grid.Cells[16, 2] = new JediwarCell(16, 2, _env["grass"]);
            grid.Cells[16, 3] = new JediwarCell(16, 3, _env["city"]);
            grid.Cells[16, 4] = new JediwarCell(16, 4, _env["city"]);
            grid.Cells[16, 5] = new JediwarCell(16, 5, _env["grass"]);
            grid.Cells[16, 6] = new JediwarCell(16, 6, _env["grass"]);
            grid.Cells[16, 7] = new JediwarCell(16, 7, _env["grass"]);
            grid.Cells[16, 8] = new JediwarCell(16, 8, _env["grass"]);
            grid.Cells[16, 9] = new JediwarCell(16, 9, _env["dirt"]);
            grid.Cells[16, 10] = new JediwarCell(16, 10, _env["water"]);
            grid.Cells[16, 11] = new JediwarCell(16, 11, _env["water"]);
            grid.Cells[16, 12] = new JediwarCell(16, 12, _env["water"]);
            grid.Cells[16, 13] = new JediwarCell(16, 13, _env["water"]);
            grid.Cells[16, 14] = new JediwarCell(16, 14, _env["water"]);
            grid.Cells[16, 15] = new JediwarCell(16, 15, _env["water"]);
            grid.Cells[16, 16] = new JediwarCell(16, 16, _env["dirt"]);
            grid.Cells[16, 17] = new JediwarCell(16, 17, _env["grass"]);
            grid.Cells[16, 18] = new JediwarCell(16, 18, _env["grass"]);
            grid.Cells[16, 19] = new JediwarCell(16, 19, _env["grass"]);
            #endregion

            #region Ligne 17
            // Ligne 17 
            grid.Cells[17, 0] = new JediwarCell(17, 0, _env["grass"]);
            grid.Cells[17, 1] = new JediwarCell(17, 1, _env["grass"]);
            grid.Cells[17, 2] = new JediwarCell(17, 2, _env["grass"]);
            grid.Cells[17, 3] = new JediwarCell(17, 3, _env["grass"]);
            grid.Cells[17, 4] = new JediwarCell(17, 4, _env["grass"]);
            grid.Cells[17, 5] = new JediwarCell(17, 5, _env["grass"]);
            grid.Cells[17, 6] = new JediwarCell(17, 6, _env["grass"]);
            grid.Cells[17, 7] = new JediwarCell(17, 7, _env["grass"]);
            grid.Cells[17, 8] = new JediwarCell(17, 8, _env["grass"]);
            grid.Cells[17, 9] = new JediwarCell(17, 9, _env["dirt"]);
            grid.Cells[17, 10] = new JediwarCell(17, 10, _env["water"]);
            grid.Cells[17, 11] = new JediwarCell(17, 11, _env["water"]);
            grid.Cells[17, 12] = new JediwarCell(17, 12, _env["water"]);
            grid.Cells[17, 13] = new JediwarCell(17, 13, _env["water"]);
            grid.Cells[17, 14] = new JediwarCell(17, 14, _env["water"]);
            grid.Cells[17, 15] = new JediwarCell(17, 15, _env["water"]);
            grid.Cells[17, 16] = new JediwarCell(17, 16, _env["dirt"]);
            grid.Cells[17, 17] = new JediwarCell(17, 17, _env["grass"]);
            grid.Cells[17, 18] = new JediwarCell(17, 18, _env["grass"]);
            grid.Cells[17, 19] = new JediwarCell(17, 19, _env["grass"]);
            #endregion

            #region Ligne 18
            // Ligne 18 
            grid.Cells[18, 0] = new JediwarCell(18, 0, _env["grass"]);
            grid.Cells[18, 1] = new JediwarCell(18, 1, _env["grass"]);
            grid.Cells[18, 2] = new JediwarCell(18, 2, _env["grass"]);
            grid.Cells[18, 3] = new JediwarCell(18, 3, _env["grass"]);
            grid.Cells[18, 4] = new JediwarCell(18, 4, _env["grass"]);
            grid.Cells[18, 5] = new JediwarCell(18, 5, _env["grass"]);
            grid.Cells[18, 6] = new JediwarCell(18, 6, _env["grass"]);
            grid.Cells[18, 7] = new JediwarCell(18, 7, _env["grass"]);
            grid.Cells[18, 8] = new JediwarCell(18, 8, _env["grass"]);
            grid.Cells[18, 9] = new JediwarCell(18, 9, _env["dirt"]);
            grid.Cells[18, 10] = new JediwarCell(18, 10, _env["dirt"]);
            grid.Cells[18, 11] = new JediwarCell(18, 11, _env["water"]);
            grid.Cells[18, 12] = new JediwarCell(18, 12, _env["water"]);
            grid.Cells[18, 13] = new JediwarCell(18, 13, _env["water"]);
            grid.Cells[18, 14] = new JediwarCell(18, 14, _env["water"]);
            grid.Cells[18, 15] = new JediwarCell(18, 15, _env["dirt"]);
            grid.Cells[18, 16] = new JediwarCell(18, 16, _env["dirt"]);
            grid.Cells[18, 17] = new JediwarCell(18, 17, _env["grass"]);
            grid.Cells[18, 18] = new JediwarCell(18, 18, _env["grass"]);
            grid.Cells[18, 19] = new JediwarCell(18, 19, _env["grass"]);
            #endregion

            #region Ligne 19
            // Ligne 19 
            grid.Cells[19, 0] = new JediwarCell(19, 0, _env["grass"]);
            grid.Cells[19, 1] = new JediwarCell(19, 1, _env["grass"]);
            grid.Cells[19, 2] = new JediwarCell(19, 2, _env["grass"]);
            grid.Cells[19, 3] = new JediwarCell(19, 3, _env["grass"]);
            grid.Cells[19, 4] = new JediwarCell(19, 4, _env["grass"]);
            grid.Cells[19, 5] = new JediwarCell(19, 5, _env["grass"]);
            grid.Cells[19, 6] = new JediwarCell(19, 6, _env["grass"]);
            grid.Cells[19, 7] = new JediwarCell(19, 7, _env["grass"]);
            grid.Cells[19, 8] = new JediwarCell(19, 8, _env["grass"]);
            grid.Cells[19, 9] = new JediwarCell(19, 9, _env["grass"]);
            grid.Cells[19, 10] = new JediwarCell(19, 10, _env["dirt"]);
            grid.Cells[19, 11] = new JediwarCell(19, 11, _env["water"]);
            grid.Cells[19, 12] = new JediwarCell(19, 12, _env["water"]);
            grid.Cells[19, 13] = new JediwarCell(19, 13, _env["dirt"]);
            grid.Cells[19, 14] = new JediwarCell(19, 14, _env["dirt"]);
            grid.Cells[19, 15] = new JediwarCell(19, 15, _env["dirt"]);
            grid.Cells[19, 16] = new JediwarCell(19, 16, _env["grass"]);
            grid.Cells[19, 17] = new JediwarCell(19, 17, _env["grass"]);
            grid.Cells[19, 18] = new JediwarCell(19, 18, _env["grass"]);
            grid.Cells[19, 19] = new JediwarCell(19, 19, _env["grass"]);
            #endregion
        }
    }
}
