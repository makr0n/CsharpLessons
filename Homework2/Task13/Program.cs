// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new int();
int numberForDisplay = new int();
int thirdDigit = new int();

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
numberForDisplay = number;

if (number < 99)
{
    Console.Write("Третьего числа нет");
}

else
{
    while (number > 999)
    {
        number = number / 10;
    }
    thirdDigit = number % 10;
    
    Console.Write($"Цифра {thirdDigit} является третьей цифрой числа {numberForDisplay}");
}

