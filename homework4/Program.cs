// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// Console.WriteLine("введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// int Quter = Convert.ToInt32(Math.Pow(A,B));
// {
// Console.WriteLine($" number{Quter}");
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
// Console.WriteLine("введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int i = 1;
// while(i <= A)
// {
//     sum = sum + ( A % 10);
//     A = A / 10;
//     }
// Console.Write($"sum = {sum}");
// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры 
// и далее выводит массив на экран в одну строку.

// int[]Array = new int[8];
// Console.WriteLine("введите 1 число");
// Array[0] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите 2 число");
// Array[1] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите 3 число");
// Array[2] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите 4 число");
// Array[3] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите 5 число");
// Array[4] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите 6 число");
// Array[5] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите 7 число");
// Array[6] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите 8 число");
// Array[7] = Convert.ToInt32(Console.ReadLine());
// foreach (int item in Array) Console.Write(item);
