// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int day = new int();

System.Console.Write("Введите номер дня недели: ");
day = Convert.ToInt32(Console.ReadLine());
if (day > 0 & day < 8)
{
    if (day > 5)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}
else
{
   Console.WriteLine("День недели введен неправильно"); 
}