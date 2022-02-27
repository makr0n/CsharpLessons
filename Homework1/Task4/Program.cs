int number1 = new int();
int number2 = new int();
int number3 = new int();
int max = new int();

Console.Write("Введите первое число: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > max) 
{
    max = number1;
}
if (number2 > max) 
{
    max = number2;
}
if (number3 > max) 
{
    max = number3;
}

Console.Write("Max = ");
Console.WriteLine(max);