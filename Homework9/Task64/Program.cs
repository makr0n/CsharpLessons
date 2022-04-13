/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 7" */

void PrintNaturalNumbers(int numberM, int numberN)
{
    if (numberM <= numberN)
    {
        Console.Write(numberN + " ");
        PrintNaturalNumbers(numberM, --numberN);
    }

}
PrintNaturalNumbers(1, 5);