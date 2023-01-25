// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] Array = GetArray(10, 100, 999);
// Console.WriteLine($"[{String.Join(";", Array)}]");

// Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(Array)}");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// int GetEvenCount (int[] array)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if (item % 2 == 0) count++;
//     }
//     return count;
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// int[] Array = GetArray(10, 100, 999);
// Console.WriteLine($"[{String.Join(";", Array)}]");

// Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(Array)}");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// int GetSumOdd(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1) sum += array[i];
//     }
//     return sum;
// }

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
int[] Array = GetArray(10, 0, 10);
Console.WriteLine($"[{String.Join(";", Array)}]");
Console.WriteLine(String.Join(";", ResultArray(Array)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];

    return result;
}

