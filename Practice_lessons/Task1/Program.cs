int numbera = new int();

int numberb = new int();

int numberasquare = new int();

System.Console.Write("Введите число a: ");
numbera = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число b: ");
numberb = Convert.ToInt32(Console.ReadLine());

numberasquare = numbera*numbera;

if (numberasquare == numberb)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}
