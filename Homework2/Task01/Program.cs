// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 645

int num = 32679;

int numbersCount = GetNumbersCount(num);
if(numbersCount < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int thirdNumber = GetThirdNumber(num, numbersCount);
    Console.WriteLine(thirdNumber);
}

int GetNumbersCount(int number)
{
    int count = 0;
    while(number > 0)
    {
        count ++;
        number /= 10;
    }
    return count;
}

int GetThirdNumber(int number, int numbersCount)
{
    int thirdNumber  = 0;
    while (numbersCount >= 3)
    {
        thirdNumber = number % 10;
        number /= 10;
        numbersCount--;
    }
    return thirdNumber;
}