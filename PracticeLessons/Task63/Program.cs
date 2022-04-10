/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
Используя рекурсию.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

void PrintNumbers(int num, int count = 1)
{
    if (num >= count)
    {
        Console.Write(count + " ");
        PrintNumbers(num, ++count);
    }

}

PrintNumbers(6);