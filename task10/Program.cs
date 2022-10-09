// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
{
    int secondDigit = Math.Abs(number % 100 / 10);
    Console.WriteLine($"Вторая цифра числа -> {secondDigit}");
}
else Console.WriteLine($"Введено некорректное число");
