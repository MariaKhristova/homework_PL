// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5]-> 76.2

double[] array = new double[8];
void Array(double[] collection)
{
    int i = 0;
    while (i < collection.Length)
    {
        collection[i] = new Random().Next(0, 100) * 0.1;
        i++;
    }
}

double FindMin(double[] array)
{
    var min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}

double FindMax(double[] array)
{
    var max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}

Array(array);

var min = FindMin(array);
var max = FindMax(array);
var result = max - min;
Console.WriteLine(result);

