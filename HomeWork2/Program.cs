// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    int result = (num / 10) % 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int hundreds = num / 100;

if(hundreds >= 1 && hundreds <= 9)
{
    Console.Write("Вторая цифра введенного числа: ");
    Console.Write(SecondDigit(num));
}
else
{
    Console.Write("Вы ввели некорректное число, повторите попытку.");
}

