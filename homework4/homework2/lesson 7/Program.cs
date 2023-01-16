// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[rows,cols ];
// FillArray(array);
// PrintArray(array);


// void FillArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(-10,11);
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите значения m и n в строку через пробел и нажмите ввод ");
// string[] num = Console.ReadLine().Split(' ');
// int m = Convert.ToInt32(num[0]);
// int n = Convert.ToInt32(num[1]);
// Console.WriteLine($" Количество строк = {m}; Количество столбцов = {n}");


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[rows,cols ];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
//  {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//           array[i,j] =  i + j;
//  }


// void PrintArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//     }
// }





// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:


// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// Mathquter(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 11);
// }

// void Mathquter(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             if (i != 0 && j != 0)
//                 array[i, j] = array[i, j] * array[i, j];
//         }
//     }
//     PrintArray(array);

   
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Задача 51: Задайте двумерный квадратный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 
// 5 9 2 
// 8 4 2 
// Сумма элементов главной диагонали: 1+9+2 = 12
// найдите сумму элементов обратной диагонали
 int[,] array = new int[3, 3]
 ;
