/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

bool IsNumberContains(int[] array, int Number)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]==Number)
        {
            return true;
        }
        
    }
    return false;
}

int[] exampleArray = { 6, 7, 19, 345, 3 };
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool answer = IsNumberContains(exampleArray,number);

if (answer)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}

