//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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



int MinRowSumIndex(int[,] matrix)
{
    int rowIndex = 1;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minSum += matrix[0, i];
    }
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        Console.WriteLine($"Сумма элементов строки номер {i+1} равна {rowSum} ");
        

        if (minSum > rowSum)
        {
            minSum = rowSum;
            rowIndex = i + 1;
        }
        
    }
    Console.WriteLine("---------------------------");

    return rowIndex;
}


int[,] rndMatrix = GenerateMatrix(5, 3, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(rndMatrix);
Console.WriteLine("---------------------------");
int indexMinRowSum = MinRowSumIndex(rndMatrix);
Console.WriteLine($"Номер строки с наменьшей суммой {indexMinRowSum}");
