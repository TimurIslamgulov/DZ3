﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Обращаться к числу как к строке нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// // }
// Console.WriteLine("введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x < 100) 
// {
// Console.WriteLine("у числа нет 3ий цифры");}
// else {
//     do
//     {
//      x = x / 10;}
//      while(x > 999);

// int b = x % 10;
// Console.WriteLine($"3е число{b}");}



// Задача необязательная 2: по желанию идет за 2 необязательных

// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 100 человек.

Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());
int y = x % 100;
int z = x % 10;

if (y > 10&& y< 15)
{
    
    Console.WriteLine($"{x} программистов");
}
    else if (z > 0 && z < 5)
    { Console.WriteLine($"{x} программиста");
    }
else
    {
    
Console.WriteLine($"{x} программистов");
    }
    // УРА!!!

