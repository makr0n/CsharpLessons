// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int[] RandomBinaryArray(int[] array)
{
    int[] binaryArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        binaryArray[i] = new Random().Next(0, 2);
    }
    return binaryArray;
}

void PrintArray(int[] array)
{
    int count = array.Length;

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
}

int[] emptyArray = new int[8];
int[] binaryArray = RandomBinaryArray(emptyArray);
PrintArray(binaryArray);