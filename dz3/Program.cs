// Задача №3 из презентации: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй - предпоследним и т.д.)

Console.Clear();

// Функция создания массива заполненный трёхзначными числами

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// Функция переворачивания массива

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

// Проверка своего кода для вывода массива в консоль убрать "//" в следующих 5 строках

// for ( int i = 0; i < array.Length; i++)
// {
// Console.Write($"{array[i]} ");
//     }

// Console.WriteLine();

int [] reverseArray = ReverseArray(array);

// Проверка своего кода для вывода перевернутого массива в консоль убрать "//" в следующих 5 строках

// for ( int i = 0; i < array.Length; i++)
// {
// Console.Write($"{array[i]} ");
// }