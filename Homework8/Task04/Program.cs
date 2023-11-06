// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

var m = 2;
var n = 2;
var o = 2;
var array = new int[m, n, o];
var set = new HashSet<int>();

for (var i = 0; i < m; i++)
    for (var j = 0; j < n; j++)
        for (var k = 0; k < o; k++)
        {
            var val = new Random().Next(10, 99);
            if (!set.Contains(val))
            {
                set.Add(val);
                array[i, j, k] = val;
            }
        }

PrintArray(array);

void PrintArray(int[,,] array)
{
    for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
        {
            for (var k = 0; k < o; k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");

            }
            Console.WriteLine();
        }
}