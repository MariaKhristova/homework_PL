// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("Введите пятизначное число: ");
string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);

if(numstr.Length != 5)
{
    Console.WriteLine("Число не пятизначное");
    return;
}

if(numstr[0] == numstr[4] && numstr[1] == numstr[3])
    Console.Write("да");
else
    Console.Write("нет");