// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

var m = 4;
var n = 4;
var array = new int[m, n];
for (var i = 0; i < m; i++)
    for (var j = 0; j < n; j++)
        array[i, j] = new Random().Next(10);

PrintArray(array);

var minSumm = int.MaxValue;
var minSummRow = 0;

for (int i = 0; i < m; i++)
{
    var summ = SummRow(i, array);
    if (summ < minSumm)
    {
        minSumm = summ;
        minSummRow = i + 1;
    }
}

Console.WriteLine("==============================");

Console.WriteLine($"{minSummRow} строка");

int SummRow(int i, int[,] array)
{
    var summ = 0;
    for (int j = 0; j < n; j++)
        summ += array[i, j];
    return summ;
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < m; i++)
    {
        Console.Write("| ");
        for (var j = 0; j < n; j++)
            Console.Write($"{array[i, j]} | ");
        Console.WriteLine();
    }
}