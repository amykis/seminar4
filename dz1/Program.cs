// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа  завершается при вводе символа `q` или при вводе числа, сумма цифр которого четная.

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

// Функция определяет четное число или нечетное

bool GetSumOfLastTwoElement(int[] array, int size)
{
    int sum = array[size - 1] + array[size - 2];
    if (sum % 2 == 0)
    {
        return true;
    } 
    else 
    {
       return false;
    } 
}

bool sum = false;
string word = "";
 
while (sum == false || word == "q")
{
    Console.Clear();

    // Ввод числа и отправка его в функцию GetArrayLength()

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    word = Convert.ToString(number);
    int size = GetArrayLength(number);

    // Создание массива из введенного числа, вызов функции FillArray()

    int[] array = FillArray(size, number);

    // Для проверки длины массива убрать "//" в следующей строке

    // Console.WriteLine(GetArrayLength(number));

    // Для вывода массива в консоль убрать "//" в следующих 5 строках

    // for ( int i = 0; i < array.Length; i++)
    // {
    //     Console.Write($"{array[i]} ");
    // }

    // Console.WriteLine();

    // Проверка bool

    // Console.WriteLine(GetSumOfLastTwoElement(array, size));

    sum = GetSumOfLastTwoElement(array, size);
}

Console.WriteLine("[STOP]");