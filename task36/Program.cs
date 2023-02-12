/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] InitArray()
{
    int[] result = new int[6];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-99, 100);
    }

    return result;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int GetCountNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
            count++;
    }

    return count;
}


int[] arr = InitArray();
PrintArray(arr);
int getNumOdd = GetCountNumbers(arr);

Console.WriteLine($"The number off odd numbers in the array -> {getNumOdd}");