/*Задача 1.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4*/

// *С использованием массива*

// Console.Write("Укажите, сколько чисел хотите ввести: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"Введите {i + 1}-е число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// int PositiveNumbers(int[] array)
// {
//     int total = 0;
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//             total = total + 1;
//     }
//     return total;
// }

// int result = PositiveNumbers(array);
// Console.Write($"{result} чисел из введенных больше 0.");


// *Без использования масива*

// int PositiveNumbers(int num)
// {
//     int total = 0;
//     for (int i = 0; i < num; i++)
//     {
//         Console.Write($"Введите {i+1}-е число: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());
//         if(num2 > 0)
//             total++;
//     }
//     return total;
// }

// Console.Write("Количество чисел, которое будет введено: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Вами было введено {PositiveNumbers(num)} чисел(-ла) больше 0.");



/*Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/* Необходимо объединить уравнения прямых в систему, решение которой, позволит определить точные координаты точки пересечения прямых.
Если система уравнений:
- имеет единственное решение, то прямые пересекаются;
- имеет бесконечное множество решений, то прямые совпадают;
- не имеет решений, то прямые не пересекаются (прямые параллельны между собой)*/

// void CrossLines(double k1, double b1, double k2, double b2)
// {
//     double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
//     double y = Math.Round((((k1 * (b2-b1)) / (k1 - k2)) + b1), 2);
    
//     if(k1 == k2)
//         Console.Write("Прямые являются параллельными (или совпадают), точки пересечения прямых нет.");
//     else
//         Console.Write($"Координаты точки пересечения заданных прямых ({x}; {y})");
// }

// Console.WriteLine("Чтобы увидеть координаты точки пересечения прямых y=k1*x+b1, y=k2*x+b2 введите следующие данные: ");
// Console.Write("Введите k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());

// CrossLines(k1, b1, k2, b2);








