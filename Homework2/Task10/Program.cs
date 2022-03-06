int number = new int();
int secondDigit = new int();

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

secondDigit = number / 10; //Отбрасываем первый разряд числа
secondDigit = secondDigit % 10; // Получаем значение второго разряда

Console.Write($"{secondDigit} является второй цифрой числа {number}");