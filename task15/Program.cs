// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

switch (dayNumber)
{
    case 1:
        Console.WriteLine("нет, это не выходной день");
        break;
    case 2:
        Console.WriteLine("нет, это не выходной день");
        break;
    case 3:
        Console.WriteLine("нет, это не выходной день");
        break;
    case 4:
        Console.WriteLine("нет, это не выходной день");
        break;
    case 5:
        Console.WriteLine("нет, это не выходной день");
        break;
    case 6:
        Console.WriteLine("да, это выходной день");
        break;
    case 7:
        Console.WriteLine("да, это выходной день");
        break;
    default:
        Console.WriteLine("Неккоретный номер дня недели");
        break;
}
