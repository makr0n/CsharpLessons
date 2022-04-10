int N = new int();
int count = new int();
Console.WriteLine("Введите целое число: ");
N = Convert.ToInt32(Console.ReadLine());
count = -N;

while (count <= N)
{
    Console.Write(count);
    Console.Write(" ");
    count = count + 1;
}