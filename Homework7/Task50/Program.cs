/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

int[,] GenerateMatrix(int rows, int columns, int delta)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(-delta, delta + 1);
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

int[,] generatedMatrix = GenerateMatrix(4, 4, 50);
Console.WriteLine("Исходный массив:");
PrintMatrix(generatedMatrix);
Console.WriteLine("---------------------------------------------------");

Console.WriteLine("Введите позицию элемента:");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

if (row < generatedMatrix.GetLength(0) && column <  generatedMatrix.GetLength(1))
{
    Console.WriteLine($"Искомое число {generatedMatrix[row,column]}.");
}
else
{
    Console.WriteLine("Такого числа в массиве нет.");
}
