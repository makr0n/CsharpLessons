// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 12 10
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

int[] MultiplicationOfPairsOfNumbersInArray(int[] array)
{
    int length = (int)Math.Ceiling(array.Length / 2.0);
    int[] multiplyResultArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        if (i == array.Length - i - 1)
        {
            multiplyResultArray[i] = array[i];
        }
        else
        {
            multiplyResultArray[i] = array[i] * array[array.Length - i - 1];
        }
    }
    return multiplyResultArray;
}
int[] arrayOfNumber=CreateRandomArray(7,10);
Console.Write("Исходный массив: ");
PrintArray(arrayOfNumber);
Console.WriteLine();
int[] multiplyResultArray = MultiplicationOfPairsOfNumbersInArray(arrayOfNumber);
Console.Write("Массив с произведением элементов: ");
PrintArray(multiplyResultArray);