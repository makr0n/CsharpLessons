//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] ElementByElementArrayCopy(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

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
        if (i < count - 1)
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

int[] originalArray = GetArrayOfNumbers(5, 10);
PrintArray(originalArray);
Console.WriteLine();
int[] imposterArray = ElementByElementArrayCopy(originalArray);
PrintArray(imposterArray);