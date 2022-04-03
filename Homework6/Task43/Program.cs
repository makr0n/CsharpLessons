/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/


Console.Write("Введите коэффициент k1 для первого уравнения: ");
 double coefficientK1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b1 для первого уравнения: ");
double coefficientB1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент k2 для второго уравнения: ");
double coefficientK2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b2 для первого уравнения: ");
double coefficientB2 = Convert.ToInt32(Console.ReadLine());

if (coefficientK1 != coefficientK2)
{
    double firstCoordinate = (coefficientB2 - coefficientB1) / (coefficientK1 - coefficientK2);
    Console.WriteLine(firstCoordinate);
    
    double secondCoordinate = coefficientK1 * firstCoordinate + coefficientB1;
    Console.WriteLine(secondCoordinate);

    Console.WriteLine($"Координаты точки пересечения прямых ({firstCoordinate}; {secondCoordinate})");
}
else
{
    Console.WriteLine("Линии параллельны и не пересекаются");
}
