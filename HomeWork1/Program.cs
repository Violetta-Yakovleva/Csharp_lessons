﻿//Домашняя работа 1

// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе целое число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b)
// {
//     Console.WriteLine($"Число {a} больше числа {b}.");
// }
// else
// {
//     Console.WriteLine($"Число {b} больше числа {a}");
// }



// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое целое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе целое число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье целое число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 & num1 > num3)
// {
//     Console.WriteLine($"Максимальное число {num1}");
// }

// else if(num2 > num1 & num2 > num3)
// {
//     Console.WriteLine($"Максимальное число {num2}");
// }

// else
// {
//     Console.WriteLine($"Максимальное число {num3}");
// }



// Задача 4. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0)
// // % - остаток от деления числа, если число делится на два ровно, то остаток от деления будет равен нулю, если остаток равен 1,то число - нечетное
//     Console.WriteLine($"Число {num} является четным");
// else
//     Console.WriteLine($"Число {num} является нечетным");



// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 2; i <= num; i = i + 2)
{
    Console.Write($"{i} ");
}