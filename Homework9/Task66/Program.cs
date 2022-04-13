/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int sum = 0;
int PrintSumOfNaturalNumbers(int numberM, int numberN)
{

    if (numberM <= numberN)
    {
        sum += numberM;

        PrintSumOfNaturalNumbers(++numberM, numberN);
    }
    return sum;
}
Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine()); 

PrintSumOfNaturalNumbers(numberM, numberN);
Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN} равна {sum}.");