/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GenerateMatrix(int rows, int columns, int delta)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double rndNumber = new Random().NextDouble();
            matrix[i, j] = Math.Round(-delta + rndNumber * (delta + delta), 2); //Получение вещественных чисел в диапазоне [-delta,delta)
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("введите М");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите N");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] generatedMatrix = GenerateMatrix(rows, columns, 10);

PrintMatrix(generatedMatrix);