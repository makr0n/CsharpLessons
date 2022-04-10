/* Задача 67: Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр. RECURSION
453 -> 12
45 -> 9 */

int SumOfNumbers(int number, int sum = 0)
{
    if (number > 0)
    {
        sum += number % 10;
        number /= 10;
        sum = SumOfNumbers(number, sum);
    }
    return sum;
}
Console.WriteLine(SumOfNumbers(465));