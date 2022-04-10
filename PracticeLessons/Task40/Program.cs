/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

void ExistenceOFTriangle(int a, int b, int c)
{
    if ((a + b) > c && (b + c) > a && (a + c) > b)
    {
        Console.WriteLine("Треугольник с такими сторонами существует.");
    }

    else 
    {
        Console.WriteLine("Треугольника с такими сторонами не существует.");
    }
}

Console.WriteLine("Первая сторона:");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая сторона:");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третья сторона:");
int thirdSide = Convert.ToInt32(Console.ReadLine());

ExistenceOFTriangle(firstSide, secondSide, thirdSide);