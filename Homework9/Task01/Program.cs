﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

var n = 8;

void PrintN(int i)
{
    Console.Write(i);
    if (i > 1)
    {
        Console.Write(", ");
        PrintN(i - 1);
    }
}

PrintN(n);