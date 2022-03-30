/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] GetArrayOfRandomNumbers(int length, int deviation)
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

int SumOfElementsInOddPositions(int[] array)
{
    int sumOfNumbersInOddPositions = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sumOfNumbersInOddPositions = sumOfNumbersInOddPositions + array[i];
        }
    }
    return sumOfNumbersInOddPositions;
}


int[] randomArray = GetArrayOfRandomNumbers(4, 10);
PrintArray(randomArray);
int sumOfNumbersInOddPositions = SumOfElementsInOddPositions(randomArray);
Console.Write($"Сумма элементов на нечётных позициях равна {sumOfNumbersInOddPositions}.");