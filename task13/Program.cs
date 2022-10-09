// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    int thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра числа -> {thirdDigit}");
}
else Console.WriteLine("Третьей цифры нет");

