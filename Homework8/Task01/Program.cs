// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

var m = 4;
var n = 4;
var array = new int[m, n];
for (var i = 0; i < m; i++)
    for (var j = 0; j < n; j++)
        array[i, j] = new Random().Next(10);

PrintArray(array);

for (int i = 0; i < m; i++)
{
    SortRow(i, array);
}

Console.WriteLine("==============================");

PrintArray(array);

void SortRow(int i, int[,] array)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = j; k < n; k++)
        {
            if (array[i, j] < array[i, k])
            {
                var a = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = a;
            }
        }
    }
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