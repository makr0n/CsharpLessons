/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */

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

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i < count - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
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



int[] SortArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0) - i - 1; j++)
        {
            if (array[j] < array[j + 1])
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
    int[] returningArray = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        returningArray[i] = matrix[index, i];
    }
    return returningArray;
}


void SortedMatrix(int[,] nonSortedMatrix)
{
    for (int i = 0; i < nonSortedMatrix.GetLength(0); i++)
    {
        int[] nonSortedRow = GetArrayByIndex(nonSortedMatrix, i);
        int[] sortedRow = SortArray(nonSortedRow);
        PrintArray(sortedRow);
    }
}


int[,] nonSortedMatrix = GenerateMatrix(5, 3, 10);
Console.WriteLine("Исходный массив:");
PrintMatrix(nonSortedMatrix);
Console.WriteLine("---------------------------------------------------");
SortedMatrix(nonSortedMatrix);