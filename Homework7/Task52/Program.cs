/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


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

void AverageSumOfElementsInEachColumn(int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double averageSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageSum = averageSum + matrix[i, j];
        }
        averageSum = averageSum / matrix.GetLength(0);
        Console.Write($"{averageSum}; ");
    }
}

int[,] rndMatrix = GenerateMatrix(4, 4, 5);
Console.WriteLine("Исходный массив:");
PrintMatrix(rndMatrix);
Console.WriteLine("---------------------------------------------------");
Console.Write("Среднее арифметическое каждого столбца: ");
AverageSumOfElementsInEachColumn(rndMatrix);
