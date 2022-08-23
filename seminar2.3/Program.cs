System.Console.Write("Введите цифру от 1 до 7 которая обозначает день недели: ");
int index = Convert.ToInt32(Console.ReadLine());
string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// int index = digit;
if (index < 8 && index > 0)
{
    if (index == 6 || index == 7) Console.Write($"Введённая цифра {index} это {array[index - 1]} и это выходной");
    else Console.Write($"Введённая цифра {index} это {array[index - 1]} и это не выходной");
}
else Console.Write($"Введённая цифра {index} меньше 1 или больше 7");