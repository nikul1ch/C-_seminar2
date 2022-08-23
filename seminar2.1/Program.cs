System.Console.Write("Введите трёхзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int number = digit;
if (digit > 99 && digit < 1000)
{
    digit /= 10;
    digit %= 10;
    Console.Write($"Вторая цифра числа {number} это {digit}");
}
else Console.Write("Число не двухзначное");