/* Задача 72: Заданы 2 массива: info и data. В массиве data хранятся двоичные представления нескольких чисел (без разделителя). 
В массиве info хранится информация о количестве бит, которые занимают числа из массива data. 
Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1 */


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

void PrintingArrayOfBinaryNumbers(int[] data, int[] info)// метод для вывода на экран отдельных двоичных чисел из общего массива data
{
    int k = 0;
    Console.Write("[");
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = 0; j < info[i]; j++)
        {
            Console.Write(data[j + k]);
        }
        if (i < info.Length-1)
        {
            Console.Write(", ");
        }    
        k += info[i];
    }
    Console.Write("]");
    Console.WriteLine();
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

int[] ConvertedBinaryToDecimalArray(int[] data, int[] info)
{
    int k = 0;
    int[] decimalArray = new int[info.Length];
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = 0; j < info[i]; j++)
        {
            decimalArray[i] += data[j + k] * (int)Math.Pow(2, info[i] - 1 - j);
        }
        k += info[i];
    }
    return decimalArray;
}


PrintingArrayOfBinaryNumbers(data, info);
Console.WriteLine();
int[] decArr = ConvertedBinaryToDecimalArray(data, info);
PrintArray(decArr);
