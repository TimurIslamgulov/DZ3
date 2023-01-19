// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// Console.WriteLine("Введите размерность массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[N];
// FillArray(array);
// PrintArray(array);
// SummArray(array);

// void FillArray(int [] array)
// {
//     for (int i=0;i<array.Length; i++)
//         array[i] = new Random().Next(100,1000);}

// void PrintArray(int [] mas)
// {
//     for (int i=0;i<mas.Length; i++)
//         Console.Write($"{mas[i]} ");
//     Console.WriteLine();
// }
// void SummArray(int[]array)//количество четных
//    {  int b = 0;
//         int c =0;

//     for (int i=0;i<array.Length; i++)
//         if (  array[i] % 2 == 0)
//        {b = b + 1;}
//         else  c = c + 1;
//     Console.WriteLine( $"четных чисел {b}");  
//     Console.WriteLine( $"нечетных чисел {c}");
//    }  

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите
//  сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
// Console.WriteLine("Введите размерность массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[N];
// FillArray(array);
// PrintArray(array);
// SummArray(array);

// void FillArray(int [] array)
// {
//     for (int i=0;i<array.Length; i++)
//         array[i] = new Random().Next(1,1000);}

// void PrintArray(int [] mas)
// {
//     for (int i=0;i<mas.Length; i++)
//         Console.Write($"{mas[i]} ");
//     Console.WriteLine();
// }
// void SummArray(int[]array)
//    {  int sum = 0;
//     for (int i=0;i<array.Length; i++)
//         if (i % 2 != 0)
//         {
//         sum = sum + array[i];
//         }

//     Console.WriteLine ($"сумма = {sum}");
//    }
// Задача 38: Задайте массив вещественных чисел
// . Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];
FillArray(array);
PrintArray(array);
DiffArray(array);

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble();
}

void PrintArray(double[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($"{mas[i]} ");
    Console.WriteLine();
}

void DiffArray(double[] array)
{
    double a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > i)
            a = array[i];
    }
    double b = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < i)
            b = array[i];
    }
    double z = a - b;
    Console.WriteLine($" разница {z}");
}




