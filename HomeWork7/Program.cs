// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// *Вещественные числа - все рациональные и иррациональные числа, МБ и положительными и отрицательными.

// double[,] CreateRandome2DArray(int rows, int columns, int min, int max)
// {
//     double[,] array = new double[rows, columns];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Math.Round(Convert.ToDouble(new Random().Next(min, max + 1) + new Random().NextDouble()), 2);
//         }
//     }
//     return array;
// }

// void Show2DArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());


// double[,] newArray = CreateRandome2DArray(rows, columns, min, max);
// Show2DArray(newArray);


// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

// int[,] CreateRandom2DArray(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j= 0; j < array.GetLength(1);j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ElementSearch(int[,] array, int indexRow, int indexColumn)
// {
//     if (indexRow >= 0 && indexRow <= array.GetLength(0) - 1 && indexColumn >= 0 && indexColumn <= array.GetLength(1) - 1)
//         Console.Write($"Элемент в строке {indexRow} и столбце {indexColumn} имеет значение {array[indexRow, indexColumn]}.");
//     else
//         Console.Write($"Элемента с такими параментрами не существует.");
// }
   
// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2DArray(rows, columns, min, max);
// Show2DArray(newArray);

// Console.Write("Введите, в какой строке находится искомый элемент: ");
// int indexRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите, в каком столбце находится искомый элемент: ");
// int indexColumn = Convert.ToInt32(Console.ReadLine());

// ElementSearch(newArray, indexRow, indexColumn);


// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] CreateRandom2DArray(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j= 0; j < array.GetLength(1);j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[] SearchAverageOfColumns(int[,] array)
// {
//     double[] arrayAverage = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//            arrayAverage[j] += array[i, j];
//         }
//         arrayAverage[j] = Math.Round((arrayAverage[j] / array.GetLength(0)), 2);
//         Console.Write(arrayAverage[j] + " ");
//     }
//     return arrayAverage;
// }

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2DArray(rows, columns, min, max);
// Show2DArray(newArray);
// Console.WriteLine($"Среднее арифметическое элементов каждого столбца: ");
// SearchAverageOfColumns(newArray);