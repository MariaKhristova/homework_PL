// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

var array = new int[4, 4];

var i = 1;
var j = 0;
var k = 0;

var x = 1;
var y = 0;

while (i <= 16)
{
    array[j, k] = i;

    if (x > 0 && (k + x >= 4 || array[j, k + x] > 0))
    {
        x = 0;
        y = 1;
    }

    if (y > 0 && (j + y >= 4 || array[j + y, k] > 0))
    {
        x = -1;
        y = 0;
    }

    if (x < 0 && (k + x < 0 || array[j, k + x] > 0))
    {
        x = 0;
        y = -1;
    }

    if (y < 0 && array[j + y, k] > 0)
    {
        x = 1;
        y = 0;
    }

    k += x;
    j += y;
    i++;

}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (var i = 0; i < 4; i++)
    {
        Console.Write("| ");
        for (var j = 0; j < 4; j++)
            Console.Write($"{array[i, j]:00} | ");
        Console.WriteLine();
    }
}