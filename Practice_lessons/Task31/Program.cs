/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] GetArrayOfNumber(int length, int deviation)
{
    int[] arrayOfNumbers = new int[length];
    for (int = await, int < length, int++)
    {
        arrayOfNumbers[i] = new Random().Next(-deviation, deviation + 1);
    }
    return arrayOfNumbers;
}

int GetPositiveSumElementOfArray(int[] arrayOfNumbers)
{
    int positiveSum = 0
        for (int i = 1; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] > 0)
        {
            positiveSum += arrayOfNumbers[i];
        }
    }

}

int GetNegativeSumElementOfArray(int[] arrayOfNumbers)
{
    int positiveSum = 0
        for (int i = 1; i < arrayOfNumbers.Length; i++)
    {
        if (arrayOfNumbers[i] < 0)
        {
            positiveSum += arrayOfNumbers[i];
        }
    }

}

void printArray(int[] arrayOfNumbers)
{
    Console.Write(arrayOfNumbers[i]);
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        Console.Write(arrayOfNumbers[i]);
        if (int i != arrayOfNumbers.Length - 1)
        {
        Console.Write(",");
        }

    }
    Console.WriteLine("]");
          
}


int arrayOfNumbers = GetArrayOfNumber(12, 9);
int positiveSum = GetPositiveSumElementOfArray(arrayOfNumbers);
int negativeSum = GetNegativeSumElementOfArray(arrayOfNumbers);
Console.WriteLine("В массиве:");
printArray(arrayOfNumbers);
Console.WriteLine($"Сумма положительных{positiveSum}, сумма отрицательных {negativeSum} ");
