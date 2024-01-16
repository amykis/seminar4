Console.Clear();

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    foreach (int e in array)
    {
        Console.Write($"{e} ");
    }
}


// Задача: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первым месте
// а первый - на последнем месте и т.д)
// [1 2 3 4 5] =>  [5 4 3 2 1]
// [6 7 3 6] => [6 3 7 6]


int[] ReverseArray(int[] array)
{
    int k = array.Length;
    for (int i = 0; i < k / 2; i++)
    {
        int temp = array[i];
        array[i] = array[k - i - 1];
        array[k - i - 1] = temp;
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);

ShowArray(array);


int [] reverseArray = ReverseArray(array);

Console.WriteLine();

ShowArray(reverseArray);

// Задача: Задайте массив из N случайных чисел (N вводится с клавиатуры).

// Найдите количество чисел, которые оканчиваются на 1 и делится нацело на 7.

// Пример [1 5 11 21 81 4 0 91 2 3]

// =>2

void FindCountDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
        {
            count++;
        }

    }
    Console.WriteLine(count);
}

Console.WriteLine();

FindCountDigits(array);