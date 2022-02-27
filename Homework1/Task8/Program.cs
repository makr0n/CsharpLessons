int N = new int();
int divisionRemainder = new int();
int count = new int();

Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

count = 1;

while (count <= N)
{
    divisionRemainder = count % 2;

    if (divisionRemainder == 0)
    {
        Console.Write(count);
        Console.Write(" ");
    }
    
    count++;
}