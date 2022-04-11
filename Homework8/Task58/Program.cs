//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GenerateMatrix(int rows, int columns, int delta)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, delta + 1);
        }
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


void MatrixMultiplication(int[,] MatrixA, int[,] MatrixB)
{
    int[,] resultMatrix = new int[MatrixA.GetLength(0), MatrixB.GetLength(1)];
    if (MatrixA.GetLength(1) == MatrixB.GetLength(0))
    {
        for (int i = 0; i < MatrixA.GetLength(0); i++)
        {
            for (int j = 0; j < MatrixB.GetLength(1); j++)
            {
                for (int k = 0; k < MatrixB.GetLength(0); k++)
                {

                    resultMatrix[i, j] += MatrixA[i, k] * MatrixB[k, j];

                }
            }
        }
        PrintMatrix(resultMatrix);
    }

    else
    {
        Console.WriteLine("Матрицы не согласованы.");
    }


}



int[,] rndMatrixA = GenerateMatrix(3, 4, 3);
Console.WriteLine("Исходный массив:");
PrintMatrix(rndMatrixA);
Console.WriteLine("---------------------------");

int[,] rndMatrixB = GenerateMatrix(4, 3, 3);
Console.WriteLine("Исходный массив:");
PrintMatrix(rndMatrixB);
Console.WriteLine("---------------------------");

MatrixMultiplication(rndMatrixA, rndMatrixB);
Console.WriteLine("---------------------------");