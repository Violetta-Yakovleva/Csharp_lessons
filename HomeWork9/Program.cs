﻿// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNums(int num)
// {
//     Console.Write(num + " ");
//     if(num > 1) ShowNums(num - 1);
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// ShowNums(num);


// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumElements(int m, int n)
// {
//     if(m == n) return m;
//     else return SumElements(m + 1, n) + m;    
// }

// Console.Write("Введите первое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = SumElements(m, n);
// Console.Write($"Сумма натуральных элементов между {m} и {n} равняется {result}.");


// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akkerman(int m, int n)
// {
//     if(m == 0) 
//         return n + 1;
//     else if(n == 0 && m > 0) 
//         return Akkerman(m - 1, 1);
//     else 
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Console.Write("Введите первое неотрицательное целое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе неотрицательное целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Akkerman(m, n);
// Console.Write($"Функция Аккермана будет равняться {Akkerman(m, n)}.");