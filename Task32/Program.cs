/*
Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] GetArrayOfNumber(int length, int deviation)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation, deviation);
    }
    return arrayOfNumbers;
}

int[] reverseDigits(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


int[] arrayOfNumbers = GetArrayOfNumber(4,9);
PrintArray(arrayOfNumbers);
Console.WriteLine();
reverseDigits(arrayOfNumbers);
PrintArray(arrayOfNumbers);