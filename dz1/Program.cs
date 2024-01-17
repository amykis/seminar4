// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа  завершается при вводе символа `q` или при вводе числа, сумма цифр которого четная.

Console.Clear();

// Функция определения длины массива

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

// Функция создания массива из цифр

int[] FillArray(int size, int number)
{
    int [] array = new int [size];
    for (int i = array.Length - 1; i >= 0; i--){
    array[i] = number % 10;
    number /= 10;
    }
    return array;
}

// int GetSumOfNumbers(int sum)
// {
//     for (number > 0)
// }


// Ввод числа и отправка его в функцию GetArrayLength()

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int size = GetArrayLength(number);

// Создание массива из введенного числа, вызов функции FillArray()

int[] array = FillArray(size, number);

// Для проверки длины массива убрать "//" в следующей строке

// Console.WriteLine(GetArrayLength(number));

// Для вывода массива в консоль убрать "//" в следующих 4 строках

// for ( int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]} ");
// }