namespace LabyrinthMatrixSinglePath
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

            char[,] matrix1 =
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', 'e'},
            };

            char[,] matrix2 = new char[100, 100];
            matrix2[99, 99] = 'e';

            var lab = new Labyrinth(matrix2);
            lab.FindPaths(0, 0, 'S');
        }
    }
}
