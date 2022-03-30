/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76 */

int[] GetArrayOfNumbers(int length, int deviation)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation, deviation + 1);
    }
    return arrayOfNumbers;
}

int DifferenceBetweenMaxMinInArray(int[] array)
{
    int maxMinDifference = 0;
    int minInArray = array[0];
    int maxInArray = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (minInArray > array[i])
        {
            minInArray = array[i];
        }

        if (maxInArray < array[i])
        {
            maxInArray = array[i];
        }
    }
    
    maxMinDifference = maxInArray - minInArray;
    return maxMinDifference;
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

int[] realNumbers = GetArrayOfNumbers(4, 10);
PrintArray(realNumbers);
int maxMinDifference = DifferenceBetweenMaxMinInArray(realNumbers);
Console.Write($"Разница между максимальным и минимальным элементами массива составляет {maxMinDifference}.");