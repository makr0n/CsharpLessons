

Console.WriteLine("Введите координаты точки А");
int XCoordinateOfA = Convert.ToInt32(Console.ReadLine());
int YCoordinateOfA = Convert.ToInt32(Console.ReadLine());
int ZCoordinateOfA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
int XCoordinateOfB = Convert.ToInt32(Console.ReadLine());
int YCoordinateOfB = Convert.ToInt32(Console.ReadLine());
int ZCoordinateOfB = Convert.ToInt32(Console.ReadLine());

double VectorLength = Math.Sqrt((XCoordinateOfB - XCoordinateOfA) * (XCoordinateOfB - XCoordinateOfA) + (YCoordinateOfB - YCoordinateOfA) * (YCoordinateOfB - YCoordinateOfA) + (ZCoordinateOfB - ZCoordinateOfA) * (ZCoordinateOfB - ZCoordinateOfA)); //формула длины вектора
VectorLength = Math.Round(VectorLength, 2);
Console.WriteLine(VectorLength);
