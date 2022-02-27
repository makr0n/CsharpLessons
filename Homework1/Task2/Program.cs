int a = new int();
int b = new int();

Console.Write("Введите число a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.Write("Max = ");
    Console.WriteLine(a);
    Console.Write("Min = ");
    Console.Write(b);
}

else 
{
    Console.Write("Max = ");
    Console.WriteLine(b);
    Console.Write("Min = ");
    Console.Write(a); 
}