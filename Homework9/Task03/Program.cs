// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

var m = 3;
var n = 2;

int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;

    if (m == 0)
        return Akkerman(n - 1, 1);

    return Akkerman(n - 1, Akkerman(n, m - 1));
}

var result = Akkerman(m, n);
Console.WriteLine(result);