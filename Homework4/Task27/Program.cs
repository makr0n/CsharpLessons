/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumOfDigitsInNumber(int number)
{
    int digitsSum = 0;
    while (number > 0)
    {
        digitsSum = digitsSum + number % 10;
        number = number / 10;
    }
    return digitsSum;
}

 
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumOfDigits=SumOfDigitsInNumber(number);
Console.Write($"Сумма цифр числа {number} равна {sumOfDigits}.");

