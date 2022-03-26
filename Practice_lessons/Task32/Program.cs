/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] arrayOfNumbers = { -4, -8, 8, 2 };

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

PrintArray(arrayOfNumbers);
Console.WriteLine();
reverseDigits(arrayOfNumbers);
PrintArray(arrayOfNumbers);