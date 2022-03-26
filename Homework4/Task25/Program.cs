/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int PowerOfNumber(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result = result * number;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int power = Convert.ToInt32(Console.ReadLine());

int poweringResult=PowerOfNumber(number, power);
Console.Write($"Результатом возведения {number} в степень {power} является {poweringResult}");
