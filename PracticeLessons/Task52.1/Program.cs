// Задается двухмерный массив, найти медиану каждого столбца

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


void PrintArray(int[] incomingArray, string arrayName)
{
    Console.WriteLine($"Вывод массива {arrayName}");
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        Console.Write($"{incomingArray[i]}\t");
    }
    Console.WriteLine();
    Console.WriteLine("------------------------------------");
}



void PrintMatrix(int[,] matrix, string matrixName)
{
    Console.WriteLine($"Вывод массива {matrixName}");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("--------------------------------------");
}


int[] SortArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0) - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int buf = array[j];
                array[j] = array[j + 1];
                array[j + 1] = buf;

            }
        }
    }
    return array;
}


int[] GetArrayByIndex(int[,] matrix, int index)
{
    int[] returningArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        returningArray[i] = matrix[index, i];
    }
    return returningArray;
}

int[] GetRowsMedian(int[,] matrix)
{
    int[] medianArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] arrayToSort = GetArrayByIndex(matrix, i);
        
        int[] sortedArray = SortArray(arrayToSort);
        
        int middleIndex = (int)Math.Ceiling((double)(matrix.GetLength(0) / 2));
        if (matrix.GetLength(0) % 2 == 0)
        {
            medianArray[i] = (sortedArray[middleIndex] + sortedArray[middleIndex + 1]) / 2;
        }
        else
        {
            medianArray[i] = sortedArray[middleIndex];
        }
    }
    return medianArray;
}

int[,] array = GenerateMatrix(5, 5, 10);
PrintMatrix(array, "Изначальный");
int[] medianArray = GetRowsMedian(array);
PrintArray(medianArray, "Медиана");


