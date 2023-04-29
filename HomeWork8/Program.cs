// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateRandom2DArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue+ 1);

//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] myArray = CreateRandom2DArray();
// Show2DArray(myArray);
// SortArray(myArray);
// Show2DArray(myArray);



// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] CreateRandom2DArray()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue+ 1);

//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void MinSumRow(int[,] array)
// {
//     int minRow = 0;
//        for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minRow += array[0, i];
//     }

//     int minSumRow = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumRow = 0;
//         for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка содержит минимальную сумму элементов");
// }

// int[,] myArray = CreateRandom2DArray();
// Show2DArray(myArray);
// MinSumRow(myArray);


// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreateRandom2DArray()
// {
//     Console.WriteLine("Введите данные матрицы");
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue+ 1);

//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] firstArray = CreateRandom2DArray();
// Show2DArray(firstArray);
// Console.WriteLine();
// int[,] secondArray = CreateRandom2DArray();
// Show2DArray(secondArray);

// int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
// if (firstArray.GetLength(1) != secondArray.GetLength(0))
// {
//     Console.WriteLine("Нельзя перемножить ");
//     return;
// }
// else
// {
//     for (int i = 0; i < firstArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondArray.GetLength(1); j++)
//         {
//             resultArray[i, j] = 0;
//             for (int k = 0; k < firstArray.GetLength(1); k++)
//             {
//                 resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
//             }
//         }
//     }
// }
// Console.WriteLine("Результат перемножения двух матриц: ");
// Show2DArray(resultArray);



// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] CreateRandom3DArray()
// {
//     Console.Write("Введите длину массивf, кол-во элементов по X: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите ширину массива, кол-во элементов по Y: ");
//     int y = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите высоту массива, кол-во элементов по Z: ");
//     int z = Convert.ToInt32(Console.ReadLine());
       
//     int[,,] array = new int[x, y, z];
//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             for(int k = 0; k < array.GetLength(2); k++)  
//                 array[i,j,k] = new Random().Next(10, 100);
//     return array;
// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// int[,,] myArray = CreateRandom3DArray();
// Show3DArray(myArray);


// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void ArraySpiral(int[,] array, int n)
// {
//     int i = 0;
//     int j = 0;
//     int count = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = count++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = count++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = count++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = count++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите размер массива из учета, что количество строк = количеству столбцов: ");
// int lenght = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = new int[lenght, lenght];
// ArraySpiral(myArray, lenght);
// ShowArray(myArray);
