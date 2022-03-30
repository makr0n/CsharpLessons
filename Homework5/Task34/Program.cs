/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GetArrayOfThreeDigitPositiveNumbers(int length)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[i] = new Random().Next(100, 1000);
    }
    return arrayOfNumbers;
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

int NumberOfEvenNumbersInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Укажите количество чисел в массиве: ");
int threeDigitNumbersArrayLength = Convert.ToInt32(Console.ReadLine()); //
int[] threeDigitNumbersArray = GetArrayOfThreeDigitPositiveNumbers(threeDigitNumbersArrayLength);
PrintArray(threeDigitNumbersArray);
int evenNumbersQuantity = NumberOfEvenNumbersInArray(threeDigitNumbersArray);
Console.Write($"Количество четных чисел в массиве {evenNumbersQuantity}.");