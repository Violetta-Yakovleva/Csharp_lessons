/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


double NumPower(double num1, double num2)
{
    double power = 1;

    for(double i = 1; i <= num2; i++)
    {
        power = power * num1;
    }
    return power;
}

Console.Write("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите натуральное число B, которое будет являться степенью числа А: ");
double b = Convert.ToDouble(Console.ReadLine());

if (b > 0 && b % 1 == 0) 
{
    double newNumPower = Math.Round(NumPower(a, b), 2);
    Console.Write($"Число {a} в степени {b} это {newNumPower}");
}

else Console.WriteLine("Вы ввели не натуральное число, повторите попытку");*/



/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


int SummDigit(int num)
{
   int num1 = num;
   int sumDigit = 0;
   
    while(num1 > 0)
   {
        int lastDigit = num1 % 10;
        sumDigit = sumDigit + lastDigit;
        num1 = num1 / 10;
   }
   return sumDigit;
}

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = SummDigit(a);

Console.WriteLine($"Сумма цифр введенного числа {a} равняется {result}");*/



/*Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


/*int[] CreateYourArray(int size)
{

}


void ShowArray(int[] array)
{

}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());*/





