Console.WriteLine("Введите номер четверти: ");
int cartesianQuadrant = Convert.ToInt32(Console.ReadLine());

if (cartesianQuadrant == 1)
{
    Console.WriteLine("X от 0 до +Бесконечности; Y от 0 до +Бесконечности");
}
else if (cartesianQuadrant == 2)
{
    Console.WriteLine("X от 0 до -Бесконечности; Y от 0 до +Бесконечности");
}

else if (cartesianQuadrant == 3)
{
    Console.WriteLine("X от 0 до -Бесконечности; Y от 0 до -Бесконечности");
}

else if (cartesianQuadrant == 4)
{
    Console.WriteLine("X от 0 до +Бесконечности; Y от 0 до -Бесконечности");
}
else
{
    Console.WriteLine("ZERO");
}