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



// Seminar 3.
// Задача1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void ShowRange(int quadrant)
// {
//     if(quadrant == 1) Console.WriteLine("x > 0 and y > 0"); 
//     else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
//     else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
//     else if(quadrant == 4) Console.WriteLine("x > 0 and x < 0");
//     else Console.WriteLine("Quadrant doesnt exist");
// }

// Console.WriteLine("Input a number of quadrant: ");
// int quadNum = Convert.ToInt32(Console.ReadLine());

// ShowRange(quadNum);



// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится эта точка.

// int Div (int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;

//     return -1;
// }

// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Div(x, y));


// Задача 3.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double Div (double x1, double y1, double x2, double y2)
// {
//     double len_x = x2 - x1;
//     double len_y = y2 - y1;

//     double len_xy = Math.Sqrt(len_x * len_x + len_y * len_y);

//     return len_xy;
// }

// Console.Write("Введите координату X1: ");
// double x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y1: ");
// double y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату X2: ");
// double x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y2: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(Div(x1, y1, x2, y2), 2));


// Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// void Div(int num)
// {
//     for(int i = 1; i <= num; i++) Console.WriteLine($"{i} - {i*i}");
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Div(num);



// Семинар 4.
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А. (for или while)

// int GetSum(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//             sum = sum + i;
//     return sum;
// }

// int i = 1;
// while(i <= num)
// {
//     sum = sum + i;
//     i++;
// }

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int result = GetSum(a);
// Console.WriteLine($"Сумма чисел от 1 до {a} это {result}");



// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int CountNum(int num)
// {
//     int total = 0;
//     // int trash = 0;

//     while(num > 0)
//     {
//         total++;
//         num = num / 10;
//     }
//     return total;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Цифр в числе {num} {CountNum(num)}");


// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


// int MultNum(int num)
// {
//     int total = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         total = total * i;
//     }
//     return total;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Факториал числа {num} = {MultNum(num)}");




// Генерируем массив

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }


//Вывод массива

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Ведите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);


/*Семинар 5.
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.*/

// Генерируем массив

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }


// // Вывод массива

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Ведите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] GetNegativeNumbers(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i <= 0; i++)
//     {
//         if(array[i] < 0)
//             sum += array[i]; // sum = sum + array[i]
//     return sum;
//     }
// }

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int result = GetNegativeNumbers(newArray);
// Console.WriteLine($"Сумма отрицат. чисел равняется {result}");


// Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] ReNum(int[] array)
// {
//     for(int i =0; i < array.Length; i++) 
//         array[i] = array[i] * (-1);
//     return array;
// }




// Задача 3. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// bool YourNum(int[] array, int num)
// {
//     for(int i =0; i < array.Length; i++)
//     {
//         if(array[i] == num)
//             return true; 
//     }
//     return false;
// }






// Задача 4.Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].


// int[] CreateRandomeArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int SearchNum(int[] array, int a, int b)
// {
//     int total = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= a && array[i] <= b)         
//             total ++;
//     }
//     return total;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] newArray = CreateRandomeArray(10, 1, 100);
// ShowArray(newArray);

// Console.WriteLine(SearchNum(newArray, 10, 40));




//Семинар 6.
//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)


// int[] CreateRandomeArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void ReverseArray(int[] array)
// {
//     for (int left = 0, right = array.Length - 1; left < right; left++, right--)
//     {
//         int temp = array[left];
//         array[left] = array[right];
//         array[right] = temp;
//     }
// }

// int[] myArray = {1, 2, 3, 4, 5};
// int[] superArray = myArray;
// ReverseArray(myArray);

// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.WriteLine(myArray + " ");
// }


//Задача 1.  Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// bool Triangle (double a, double b, double c)
// {
//     if (a + b > c && b + c > a && c + a > b)
//         return true;
//     else return false;
// }

// Console.Write("Введите длину первой стороны треугольника: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите длину второй стороны треугольника: ");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите длину третьей стороны треугольника: ");
// double c = Convert.ToDouble(Console.ReadLine());

// if (Triangle(a, b, c) == true)
//     Console.WriteLine("Такой треугольник существует");
// else
//     Console.WriteLine("Такого треугольника не существует");

// ****Console.WriteLine(Triangle(a, b, c));



// Задача 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//f(n)=f(n-1)+f(n-2)

// int[] Fibonacci(int a1, int a2, int n)
// {
//     int[] array = new int[n];
//     array[0] = a1;
//     array[1] = a2;

//     for (int i = 2; i < n; i++)
//         array[i] = array[i - 1] + array[i - 2];
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
//     Console.WriteLine();   
// }

// Console.Write("Введите число, чтобы вывести числа Фибоначчи: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Первое число Фибоначчи равняется: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Второе число Фибоначчи равняется: ");
// int a2 = Convert.ToInt32(Console.ReadLine());

// int[] myArray = Fibonacci(a1, a2, n);
// ShowArray(myArray);



// Задача 3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] CopyArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//         newArray[i] = array[i];
//     return newArray;
// }


//Задача с **. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// string ConvertToByte(int n)
// {
//     string s = string.Empty;
//     while (n >= 2)
//     {
//         s = n % 2 + s;
//         n = n / 2;
//     }
//     s = n + s;
//     return s;
// }
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(ConvertToByte(n));



// Семинар 7.
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.


int[,] CreateRandom2DArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+ 1);

    return array;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);


//Задача 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
//по формуле: Aij = i+j. Выведите полученный массив на экран. 
// метод генерирующий, должен появиться новый массив в итоге

int[,] Array2D(int)








//Задача 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ссылочный тип данных








//Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// матрица мб любого размера
//можено рещить без вложенных циклов
//аналитич

