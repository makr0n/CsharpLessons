/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int[] GenerateArray(int length, int maxValue)
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(0, maxValue + 1);
    }
    return returningArray;
}

int[] RotateArray(int[] inputArray)
{
    int[] returningArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        returningArray[i] = inputArray[inputArray.Length - i - 1];
    }
    return returningArray;
}

void PrintArray(int[] inputArray)
{
    Console.Write("[");
    for (int i = 0; i < inputArray.Length; i++)
    {
        
        Console.Write(inputArray[i]);
        if (i != inputArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] arrayToRotate = GenerateArray(10, 10);
int[] rotatedArray = RotateArray(arrayToRotate);
int[] rotatedRotatedArray = RotateArray(rotatedArray);
Console.Write("Сгенерированный массив: ");
PrintArray(arrayToRotate);
Console.Write("Перевернутый массив: ");
PrintArray(rotatedArray);
Console.Write("Перевернутый еще раз массив: ");
PrintArray(rotatedRotatedArray);