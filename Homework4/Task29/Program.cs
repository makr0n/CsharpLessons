/*
Задача 29: Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GetArrayOfNumbers(int length, int deviation)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation, deviation + 1);
    }
    return arrayOfNumbers;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i < count-1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]} ");
        }
    }
    Console.Write("]");
}

int[] arr = GetArrayOfNumbers(5, 100);
PrintArray(arr);