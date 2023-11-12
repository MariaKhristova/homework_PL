// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

var m = 4;
var n = 8;

int Summ(int i, int max)
{
    var summ = i;
    if (i < max)
        summ += Summ(i + 1, max);
    return summ;
}

var sum = Summ(m, n);
Console.WriteLine(sum);