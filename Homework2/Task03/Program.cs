// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, обозначающее день недели (от 1 до 7): ");
int weekNum = Convert.ToInt32(Console.ReadLine());

if (1 < weekNum && weekNum < 6) 
    Console.WriteLine("Нет");
else if (6 < weekNum && weekNum < 8) 
    Console.WriteLine("Да");
else  
    Console.WriteLine("Вы ввели неверное число");