/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] CreateRandomArray(int length, int deviation)
{
    int[] rndArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        rndArray[i] = new Random().Next(-deviation, deviation + 1);
    }
    return rndArray;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int TheNumberOfArrayElementsPerSegment(int[] array, int segmentStart, int segmentEnd)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= segmentStart && array[i] <= segmentEnd)
        {
            count++;
        }
    }
    return count;
}

/*
//int[] newArray = {5, 18, 123, 6, 2};
//int[] newArray = {1, 2, 3, 6, 2};
int[] newArray = {10, 11, 12, 13, 14};
int theNumberOfElements = TheNumberOfArrayElementsPerSegment(newArray,10,99); //Для проверки условия примером из задания
Console.WriteLine(theNumberOfElements);
*/

int[] newArray = CreateRandomArray(123, 200);
//PrintArray(newArray);
//Console.WriteLine();
int theNumberOfElements = TheNumberOfArrayElementsPerSegment(newArray,10,99);
Console.WriteLine(theNumberOfElements);
