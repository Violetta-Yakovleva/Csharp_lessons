// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigit(int num)
// {
//     int result = (num / 10) % 10;
//     return result;
// }

// Console.Write("Введите трехзначное число и я покажу тебе его вторую цифру: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int hundreds = num / 100;

// if(hundreds >= 1 && hundreds <= 9)
// {
//     Console.Write("Вторая цифра введенного числа: ");
//     Console.Write(SecondDigit(num));
// }
// else
// {
//     Console.Write("Вы ввели некорректное число, повторите попытку.");
// }



// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdDigit (int num)
// {
//     while(num >=1000)
//     {
//         num = num / 10;
//     }
//     return num % 10;
// }
   

// Console.WriteLine("Введите число и я покажу тебе его третью цифру: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num < 100)
// {
//     Console.WriteLine("Вы ввели слишком маленькое число, введите трехзначное и более."); 
// }
// else
// {
//     Console.Write("Третья цифра введенного числа: ");
//     Console.Write(ThirdDigit (num));
// }



// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


bool Weekend(int numday)
{
    if(numday >= 6 && numday <= 7) return true;
    else return false;
}

Console.WriteLine("Введите цифру, обозначающую день недели, и я подскажу, является ли он выходным: ");
int numday = Convert.ToInt32(Console.ReadLine());

if(Weekend(numday) == true) 
Console.WriteLine("Да, день является выходным");
else 
Console.WriteLine("День не является выходным");