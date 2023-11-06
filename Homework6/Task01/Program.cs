// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2-> 2
//- 1, -7, 567, 89, 223-> 3

var positiveNumbers = 0;

void InputNumber()
{
    Console.WriteLine("Введите число: ");
    string numstr = Console.ReadLine();
    if (numstr == "")
        return;
    int num = Convert.ToInt32(numstr);
    if (num > 0)
        positiveNumbers++;
    InputNumber();
}

InputNumber();
Console.WriteLine("Чисел больше нуля: " + positiveNumbers);
