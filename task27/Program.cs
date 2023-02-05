﻿// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int Input()
// {
//     Console.WriteLine("Введите число");
//     int count = int.Parse(Console.ReadLine()!);
//     return count;
// }

// int Counter(int number) //вычисляю порядок числа (начало с 1)
// {
//     int count = 1;
//     for (int del = 10; number / del > 0; del *= 10)
//     {
//         count++;
//     }
//     return count;
// }

// double magic(int number, int rank) //отделяю цифры и складываю
// {
//     int result = 0;
//     for (int i = 1; i <= rank; i++)
//     {
//         result += number % Math.Pow(10, i) / Math.Pow(10, i - 1);
//     }

//     return result;
// }


// void Main()
// {
//     Console.Clear();
//     int number = Input();
//     int por9dok = Counter(number);
//     Console.WriteLine(magic(number, por9dok));

// }

// Main();


double magic(double number, int rank) //отделяю цифры и складываю
{
    double result = 0;
        
    for (int i = 1; i <= rank; i++)
    {
        // left = number % Math.Pow(10, i);
        // right = left / Math.Pow(10, i - 1);
        // result += right;
        result += number % Math.Pow(10, i) / Math.Pow(10, i - 1);
        Console.WriteLine(result);
    }
    return result;
}

Console.WriteLine(magic(1234, 4));
