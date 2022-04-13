/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */


int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0)
    {
        return AckermannFunction(numberM - 1, 1);
    }
    else
    {
        return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    }
}

Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Ошибка, необходимо ввести неотрицательные числа");
}
else
{
    Console.WriteLine($"Функция Аккермана А ({numberM}, {numberN}) = {AckermannFunction(numberM, numberN)}");
}

