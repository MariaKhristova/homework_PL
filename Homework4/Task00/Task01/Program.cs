// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());


void Fact(int number)
{
    int temp = 0;
    while (number > 0)
    {
        temp = temp + number %10;
        number = number / 10;
    }
     Console.WriteLine(temp);
}

Fact(num);
