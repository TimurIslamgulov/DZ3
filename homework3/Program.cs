Console.WriteLine("number");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 10000)
    Console.WriteLine(" число не 5 значное");
else  {
    int y = x % 10;
    int z = x % 100;
    int c = x % 1000;
    int r = x % 10000;
    int p = x / 10000;

        if (p == y || z == r)

        Console.WriteLine(" число полиндром");
        else
        Console.WriteLine("bad");
}


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.WriteLine("Введите координату х первой точки"); 
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату у первой точки"); 
// int y1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату z первой точки"); 
// int z1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату х второй точки"); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату у второй точки"); 
// int y2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату z второй точки"); 
// int z2 = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine(Dist(x1, y1, z1, x2, y2, z2)); 


// // double Dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))+Math.Pow((z2 - z1), 2)); 
// // Console.WriteLine($"Расстояние равно {Dist}"); 

// double Dist(int x1, int y1, int z1, int x2, int y2, int z2) 
// { 
//     double D = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2)); 
//     return D; 
// }
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("веведите число x");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; x <= i; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}

Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= x; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
