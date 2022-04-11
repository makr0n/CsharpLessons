//Задача 62: Заполните спирально массив 4 на 4.

int[,] GenerateSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int numbers = 1;
    int count = 0;
    count = rows / 2;

    for (int k = 0; k < count; k++)
    {
        for (int j = 0 + k; j < columns - k; j++)
        {
            matrix[0 + k, j] = numbers;
            numbers++;
        }

        for (int i = 1 + k; i < rows - k; i++)
        {
            matrix[i, columns - k - 1] = numbers;
            numbers++;
        }

        for (int j = columns - 2 - k; j >= 0 + k; j--)
        {
            matrix[rows - k - 1, j] = numbers;
            numbers++;
        }

        for (int i = rows - 2 - k; i > 0 + k; i--)
        {
            matrix[i, 0 + k] = numbers;
            numbers++;
        }
    }
    if (rows % 2 == 1 && columns % 2 == 1)                //условие для заполнения матрицы NxN, где N нечетное число
    {
        matrix[rows / 2, columns / 2] = rows * columns;
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
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

int[,] rnd = GenerateSpiralMatrix(4, 4);
PrintMatrix(rnd);