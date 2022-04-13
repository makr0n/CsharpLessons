/* Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

void NewFibonacci(int num1, int num2, int count)
{
    Console.Write($"{num1} ");
    if (count > 1)
    {
       NewFibonacci(num2, num1 + num2, --count);
    }
}

NewFibonacci(3,4,5);
Console.WriteLine();
NewFibonacci(6,10,4);