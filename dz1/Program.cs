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

// Функция суммы элементов массива

int GetSumOfElement(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];   
    }
    return sum;
}

// Функция возврата bool значения, суммы элементов массива на четность или нечетнность

bool GetSumOfElementEvenOrOdd(int sum)
{
    if (sum % 2 == 0)
    {
        return true;
    } 
    else 
    {
       return false;
    } 
}


bool sumEvenOrOdd = false;
 
while (sumEvenOrOdd == false )
{
    Console.Clear();

    // Ввод числа и определение его длины с помощью функции GetArrayLength()

    Console.WriteLine("Введите число: ");    
    string? text = Console.ReadLine();
    if (text != "q"){
        int number = Convert.ToInt32(text);
        int size = GetArrayLength(number);

        // Создаем массив из введенного числа, вызов функции FillArray()

        int[] array = FillArray(size, number);

        // Получаем сумму элементов массива

        int sum = GetSumOfElement(array);

        // Получаем bool значение суммы элементов массива на четность или нечетнность

        sumEvenOrOdd = GetSumOfElementEvenOrOdd(sum);

        // Для проверки длины массива убрать "//" в следующей строке

        // Console.WriteLine(GetArrayLength(number));

        // Для вывода массива в консоль убрать "//" в следующих 5 строках

        // for ( int i = 0; i < array.Length; i++)
        // {
        //     Console.Write($"{array[i]} ");
        // }

        // Console.WriteLine();

        // Console.WriteLine(GetSumOfLastTwoElement(array, size));
    }else {
        break;
    }    
}

Console.WriteLine("[STOP]");