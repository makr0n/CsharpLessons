// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int FactorialOfNumber(int number)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {A} = {FactorialOfNumber(A)}");