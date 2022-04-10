
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
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    } 
}

Console.WriteLine("введите М");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите N");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] generatedMatrix=GenerateMatrix(rows, columns, 50);

PrintMatrix(generatedMatrix);