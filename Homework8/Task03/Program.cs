// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

var m = 2;
var n = 2;
var matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
var matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };
var result = new int[m, n];

for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
    {
        result[i, j] = TimesSumm(i, j);
    }

int TimesSumm(int row, int col)
{
    var summ = 0;
    for (int i = 0; i < m; i++)
        summ += matrix1[row, i] * matrix2[i, col];
    return summ;
}

PrintArray(result);

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