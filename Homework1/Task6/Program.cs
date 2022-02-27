int number = new int();
int divisionRemainder = new int();

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

divisionRemainder = number % 2; //Получаем остаток от деления на 2

if (divisionRemainder == 0)
{
    Console.Write("Число чётное");
}

else 
{
    Console.Write("Число нечётное");
}