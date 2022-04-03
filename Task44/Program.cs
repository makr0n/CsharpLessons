/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

void FibonacciSequence(int num)
{
    int num1 = 0;
    Console.Write(num1);
    Console.Write(" ");
    int num2 = 1;
    for (int i = 1; i < num; i++)
    {
        int buf = num1;
        num1 = num2;
        num2 = buf + num2;
        Console.Write(num1);
        Console.Write(" ");
    }

}

FibonacciSequence(15);
