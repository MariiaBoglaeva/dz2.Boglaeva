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
    int count = 0;
    var numberList = new List<int>(); // объявление списка ( в отличии от массива не нужно задавать исходную длину)
    while (number > 0)
    {
        numberList.Add(number % 10);// каждый элемент списка - отдельная цифра числа. Итог Список - число записанное наборот
        number = number / 10;
        count++;

    }
int size = numberList.Count;//вычисляем длину списка (количество цифр в числе)
var thirdElement = numberList[size - 3];
Console.WriteLine($"Третья цифра числа -> {thirdElement}");
}
else Console.WriteLine("Третьей цифры нет");

