// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234]-> 2

int[] array = new int[8];
void Array(int[] collection)
{
    int i = 0;
    while (i < collection.Length)
    {
        collection[i] = new Random().Next(100, 999);
        i++;
    }
}


Array(array);

var oddCount = 0;
for (int i = 0; i < array.Length; i++)
{
    if (IsOdd(array[i]))
        oddCount++;
}

bool IsOdd(int num)
{
    return (num % 2 == 0);
}

Console.WriteLine(oddCount);

