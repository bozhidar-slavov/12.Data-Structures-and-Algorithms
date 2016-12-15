namespace LabyrinthMatrix
{
    public class Startup
    {
        public static void Main()
        {
            char[,] matrix =
            {
                {' ', ' ', ' ', '*', ' ', ' ', ' '},
                {'*', '*', ' ', '*', ' ', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {' ', '*', '*', '*', '*', '*', ' '},
                {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
            };

            var labyrinth = new Labyrinth(matrix);
            labyrinth.FindPaths(0, 0);
        }
    }
}