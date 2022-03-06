int number1 = new int();
int number2 = new int();

Console.Write("Введите число a: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
number2 = Convert.ToInt32(Console.ReadLine());

if(number1>number2)
{
    Console.Write("Max = ");
    Console.WriteLine(number1);
    Console.Write("Min = ");
    Console.Write(number2);
}

else 
{
    Console.Write("Max = ");
    Console.WriteLine(number1);
    Console.Write("Min = ");
    Console.Write(number2); 
}