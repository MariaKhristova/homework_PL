// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 - 2 - 0,2
//1 - 3,3 8 - 9,9
//8 7,8 - 7,1 9

var m = 3;
var n = 4;
var array = new decimal[m, n];
for (var i = 0; i < m; i++)
    for (var j = 0; j < n; j++)
        array[i, j] = new Random().Next(10) * 0.1m;

for (var i = 0; i < m; i++)
{
    Console.Write("| ");
    for (var j = 0; j < n; j++)
        Console.Write($"{array[i, j]} | ");
    Console.WriteLine();
}