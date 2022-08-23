System.Console.Write("Введите число больше 99: ");
int digit = Convert.ToInt32(Console.ReadLine());
int number = digit;
if (digit > 99 && digit < 1000)
{
    digit /= 10;
    digit /= 10;
    Console.Write($"Третья цифра числа {number} это {digit}");
}
else if (digit > 999)
{
    digit /= 10;
    digit /= 10;
    digit %= 10;
    Console.Write($"Третья цифра числа {number} это {digit}");
}
else Console.Write("Третьей цифры нет");