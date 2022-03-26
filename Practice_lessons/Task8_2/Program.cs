string NStr = Console.ReadLine();
int N = Convert.ToInt32(NStr);

for (int i = 2; i < N; i += 2)
{
    Console.Write(i + " ");
}

Console.WriteLine();