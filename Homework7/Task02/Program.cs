//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет

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

Console.WriteLine("Введите строку: ");
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец: ");
var y = Convert.ToInt32(Console.ReadLine());

if (x >= m || y >= n)
    Console.WriteLine("Такого числа в массиве нет");
else Console.WriteLine(array[x, y]);