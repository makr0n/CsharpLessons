double VectorLength= new double();

Console.WriteLine("Введите координаты точки А");
int XCoordinateOfA = Convert.ToInt32(Console.ReadLine());
int YCoordinateOfA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
int XCoordinateOfB = Convert.ToInt32(Console.ReadLine());
int YCoordinateOfB = Convert.ToInt32(Console.ReadLine());

VectorLength=Math.Sqrt((XCoordinateOfB-XCoordinateOfA)*(XCoordinateOfB-XCoordinateOfA)+(YCoordinateOfB-YCoordinateOfA)*(YCoordinateOfB-YCoordinateOfA)); //формула длины вектора
Console.WriteLine(VectorLength);

