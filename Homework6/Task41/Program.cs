/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


int count = 0;
int enteredNumber = new int();

Console.Write("Сколько чисел необходимо проверить? ");
int amountOfNumbers = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводите числа, после каждого введеного числа нажмите клавишу Enter");
for (int i = 0; i < amountOfNumbers; i++)
{
    enteredNumber = Convert.ToInt32(Console.ReadLine());
    if (enteredNumber > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше нуля равно {count}");




