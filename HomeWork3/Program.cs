// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
// (одинаковое при прочтении слева-направо и справа-налево).

// Решение для ПЯТИЗНАЧНОГО числа

// bool Palindrome(int number)
// {
//     int a = number / 10000;
//     int b =  number % 10;
//     int c = (number / 1000) % 10;
//     int d = (number / 10) % 10;

//     if(a == b && c == d) return true;
//     else return false;
// }

// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int div = number / 10000;
// if(div >= 1 && div<= 9) 
// {
//     if(Palindrome(number) == true) 
//     Console.WriteLine("Число является палиндромом");
//     else 
//     Console.WriteLine("Число не является палиндромом");
// }
// else Console.WriteLine("Число не является пятизначным, повторите ввод.");


// Универальное решение для любого числа

// bool Palindrome(int number)
// {
//      int number1 = number;
//      int reversNumber = 0;
        
//     while(number1 > 0)
//     {
//         int lastDigit = number1 % 10;
//         reversNumber = reversNumber * 10 + lastDigit;
//         number1 = number1 / 10;
//     }

//     if(number == reversNumber) return true;
//     else return false;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(Palindrome(number) == true)
// Console.WriteLine("Число является палиндромом");
// else 
// Console.WriteLine("Число не является палиндромом");




// // Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Lenght(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double lenghtX = x2 - x1;
//     double lenghtY = y2 - y1;
//     double lengtZ = z2 - z1;

//     double lenghtXYZ = Math.Sqrt(Math.Pow(lenghtX,2) + Math.Pow(lenghtY, 2) + Math.Pow(lengtZ, 2));
//     return lenghtXYZ;
// }

// Console.WriteLine("Введите координаты первой точки в трехмерном пространстве");
// Console.Write("Координата X: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координата Y: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координата Z: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координаты второй точки в трехмерном пространстве");
// Console.Write("Координата X: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координата Y: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координата Z: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Расстояние между заданными точками равняется: ");
// Console.Write(Math.Round(Lenght(x1, y1, z1, x2, y2, z2), 2));


// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


// void NumThirdPower(int num)
// {
//     for(int n = 1; n <= num; n = n + 1)
//     Console.WriteLine($"{n} - {Math.Pow(n, 3)}"); 
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// NumThirdPower(num);
