// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа  завершается при вводе символа `q` или при вводе числа, сумма цифр которого четная.

int GetArrayLength(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

// int GetSumOfNumbers(int number)
// {
//     for (number > 0)
// }

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetArrayLength(number));