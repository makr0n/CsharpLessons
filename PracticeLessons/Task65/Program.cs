/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

void PrintNumbers(int count, int num)
{
    if (num >= count)
    {
        Console.Write(count + " ");
        PrintNumbers(++count, num);
    }

}

PrintNumbers(1, 8);