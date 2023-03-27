// int number = 5;
// double number2 = 12,4;
// string word = "my word!";
// char symbol = 't';
// bool chek = false; 

// int num1 = 5;
// int num2 = 7;

// Console.WriteLine($"My numbers are {num1} and {num2} and it is good!");


// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your namber is " + num);


//Seminar 2. 

//Task 1. 

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;

//     int result = hundreds * 10 + units;
//     return result;
// }

// int randnmber = new Random().Next(100, 1000);
// int  newnumber = CutNumber(randnmber);

// Console.WriteLine($"New version of {randnmber} is {newnumber}");


//Task 2. 

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int Comparison(int num)
// {
//     int desyatky = num / 10;
//     int units = num % 10;
//     if(desyatky > units)
//     {
//         return desyatky;
//     }
//     else
//     {
//         return units;
//     }
// }

// int randnumber = new Random().Next(10, 100);
// int  newnumber = Comparison(randnumber);

// Console.WriteLine($"Наибольшая цифра числа {randnumber} это {newnumber}");




//Task 3. 
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

// bool Multiply (int number, int div1, int div2)
// {
//         if(number % div1 == 0 && number % div2 == 0);
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
// }

// Console.WriteLine("Введите число: ");
// Console.WriteLine("Введите число a: ");
// Console.WriteLine("Введите число b: ")
// int 





//return true;
//&& - логическое и;
//|| - логическое или





//Task 4. 
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// bool TestNum(int num1, int num2)
// {
//     if(num1 == num2 * num2 || num2 == num1 * num1)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(TestNum(num1, num2));





