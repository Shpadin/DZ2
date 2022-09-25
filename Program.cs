Console.WriteLine("введите номер задачи 10 или 13 или 15");
int nunCase = int.Parse(Console.ReadLine());

switch(nunCase)
{
    case 10:
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int resalt = ((number / 10) % 10);
     Console.WriteLine($"Второе число {resalt}");
}

    break;


    case 13:
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Введите  число: ");

int number1 = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number1);
int amount1 = number1.ToString().Length;

if (amount1 <= 2)
{
    Console.WriteLine("третье число отсутствует");
}
else
{
    Console.WriteLine($"третья цифра =  {numberText[2]}");
}

  break;

    case 15:
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine("Введите цифру, обозначающую день недели:");
int nun = int.Parse(Console.ReadLine());

switch(nun)
{
        case 1: Console.WriteLine("ПОнедельник - день не явлется выходным" );
            break;
        case 2: Console.WriteLine("Вторник - день не явлется выходным");
            break;
        case 3: Console.WriteLine("Среда - день не явлется выходным");
            break;
        case 4: Console.WriteLine("Четверг - день не явлется выходным");
            break;
        case 5: Console.WriteLine("Пятница - день не явлется выходным");
            break;
        case 6: Console.WriteLine("Суббота - день явлется выходным");
            break;
        case 7: Console.WriteLine("Воскресенье - день явлется выходным");
            break;            
            default:
            Console.WriteLine("ВВеден не существующий день недели");
            break;
}
break;
default:
            Console.WriteLine("Номер задачи введен не корректно");
            break;
}