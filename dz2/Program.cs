// Задача №2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Пример [344 452 341 125] => 2

Console.Clear();

// Функция создания массива заполненный трёхзначными числами

int[] CreateRandomArrayThreeDigitNumbers(int min, int max)
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// Функция подсчёта чётных чисел в массиве

void FindCountOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }

    }
    Console.WriteLine(count);
}

int min = 100;
int max = 999;

int[] array = CreateRandomArrayThreeDigitNumbers(min, max);

FindCountOfEvenNumbers(array);

// // Проверка своего кода Для вывода массива в консоль убрать "//" в следующих 5 строках

//     for ( int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }git 

//     Console.WriteLine();