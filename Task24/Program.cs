/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int sumFromOneToNumber(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int A = Convert.ToInt32(Console.ReadLine());
int sum = sumFromOneToNumber(A);
Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");