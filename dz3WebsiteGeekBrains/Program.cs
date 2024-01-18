// Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший – на последнем.

// Пример [1 3 2 4 2 3] => 132423
// [2 3 1] => 231


Console.Clear();

// Функция получения массива случайных чисел от 0 до 9.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 9 + 1);
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

// Проверка длинны массива (не более 8)

if (size <= 8)
{
    int[] array = CreateRandomArray(size);

    // Формирование целого числа из массива

    int number = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        number = Convert.ToInt32($"{number}{array[i]}");
    }
    
    Console.Write(number);

}
else
{
    Console.WriteLine("Массив должен быть не более 8 чисел");
}
