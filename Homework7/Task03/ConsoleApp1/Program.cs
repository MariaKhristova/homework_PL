// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

var m = 3;
var n = 4;
var array = new int[m, n];
for (var i = 0; i < m; i++)
    for (var j = 0; j < n; j++)
        array[i, j] = new Random().Next(10);

for (var i = 0; i < m; i++)
{
    Console.Write("| ");
    for (var j = 0; j < n; j++)
        Console.Write($"{array[i, j]} | ");
    Console.WriteLine();
}

var array1 = new decimal[m];

for (var i = 0; i < m; i++)
{
    decimal summ = 0;
    for (var j = 0; j < n; j++)
        summ += array[i, j];
    array1[i] = summ / n;
}

Console.Write("Среднее арифметическое каждого столбца: ");
for (var i = 0; i < m; i++)
    Console.Write($"{array1[i]}; ");