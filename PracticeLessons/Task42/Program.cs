/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

string DecimalToBinary(int decimalNumber)
{
    string result = string.Empty;
    while (decimalNumber > 0)
    {
        result = decimalNumber % 2 + result;
        decimalNumber = decimalNumber / 2;
    }
    return result;
}

int number = 45;
string binaryResult = DecimalToBinary(number);
Console.WriteLine(binaryResult);