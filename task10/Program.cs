// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void SearchSecondDigit(int num)
{
    if (num > 99 && num < 1000 || num < -99 && num > -1000)
    {
        int secondDigit = Math.Abs(num % 100 / 10);
        Console.WriteLine($"Вторая цифра числа -> {secondDigit}");
    }
    else Console.WriteLine($"Введено некорректное число");
}
SearchSecondDigit(number);

