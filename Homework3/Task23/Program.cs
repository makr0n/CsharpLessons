Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i ++)
{
    int cubeNumber=i*i*i;
    Console.Write(cubeNumber + " ");
}

Console.WriteLine();