using System;

namespace HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________Home task_________________");
            //Матрица 5 * 9 найти суммы всех ее четных элементов, нечетных, строк и столбцов.
            #region Constants and variables
            const int Rows = 5;
            const int Cols = 9;
            int evencumresult = 0;
            int oddsumresult = 0;
            int rowssumresult = 0;
            int colssumresult = 0;
            int randomvalue = 0;
            int numberofrow = 1;
            int numberofcol = 1;
            Random random = new Random();
            #endregion
            #region Filling the matrix
            int[,] matrix = new int[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                
                for (int j = 0; j < Cols; j++)
                {
                    randomvalue = random.Next(1, 10);
                    matrix[i, j] = randomvalue;
                }
            }
            #endregion
            #region Showing Matrix on console
            Console.WriteLine("Current matrix : " + "\n");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("___________________________________________");
            #endregion
            #region Calculating result and output it
            for (int i = 0; i < Rows; i++)
            {
                
                for (int j = 0; j < Cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        oddsumresult += matrix[i, j];
                    }
                    else if (matrix[i, j] % 2 != 0)
                    {
                        evencumresult += matrix[i, j];
                    }
                    rowssumresult += matrix[i, j];
                
                }
                Console.WriteLine($"Total sum of all elements in {numberofrow} Row is - {rowssumresult}");
                numberofrow++;
                rowssumresult = 0;
            }
            Console.WriteLine("___________________________________________");
            for (int i = 0; i < Cols; i++)
            {

                for (int j = 0; j < Rows; j++)
                {
                    colssumresult += matrix[j, i];

                }
                Console.WriteLine($"Total sum of all elements in {numberofcol} Col is - {colssumresult}");
                numberofcol++;
                colssumresult = 0;
            }
            Console.WriteLine("___________________________________________");
            Console.WriteLine($"Total sum of every odd elemet is - {oddsumresult}");
            Console.WriteLine($"Total sum of every even elemet is - {evencumresult}");
            #endregion
            Console.ReadKey();
        }
    }
}
