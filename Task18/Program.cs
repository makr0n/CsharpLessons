Console.WriteLine("Введите номер четверти: ");
int cartesianQuadrant = Convert.ToInt32(Console.ReadLine());
switch (cartesianQuadrant)
{
    case (1):
        Console.WriteLine("X от 0 до +Бесконечности; Y от 0 до +Бесконечности");
        break;

    case (2):
        Console.WriteLine("X от 0 до -Бесконечности; Y от 0 до +Бесконечности");
        break;

    case (3):
        Console.WriteLine("X от 0 до -Бесконечности; Y от 0 до -Бесконечности");
        break;

    case (4):
        Console.WriteLine("X от 0 до +Бесконечности; Y от 0 до -Бесконечности");
        break;

}


/*if (cartesianQuadrant == 1)
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
*/