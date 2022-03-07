Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int oldValue = number;
int newValue = 0;

while (number>0)
{
    int digit = number%10;
    newValue=newValue*10+digit;
    number=number/10;
}

if (newValue == oldValue)
{
Console.Write($"Число {oldValue} является палиндромом.");
}

else
{
 Console.Write($"Число {oldValue} не является палиндромом.");   
}
