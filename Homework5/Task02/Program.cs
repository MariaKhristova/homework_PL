// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12]-> 19
// [-4, -6, 89, 6]-> 0

int[] array = new int[8];
void Array(int[] collection)
{
    int i = 0;
    while (i < collection.Length)
    {
        collection[i] = new Random().Next(-10, 10);
        i++;
    }
}


Array(array);

var summ = 0;
for (int i = 0; i < array.Length; i++)
{
    if (!IsOdd(i))
        summ += array[i];
}

bool IsOdd(int num)
{
    return (num % 2 == 0);
}

Console.WriteLine(summ);