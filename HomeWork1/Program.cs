//Домашняя работа 1

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

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 & num1 > num3)
{
    Console.WriteLine($"Максимальное число {num1}");
}

else if(num2 > num1 & num2 > num3)
{
    Console.WriteLine($"Максимальное число {num2}");
}

else
{
    Console.WriteLine($"Максимальное число {num3}");
}