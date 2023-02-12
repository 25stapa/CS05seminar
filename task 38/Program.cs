/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

float[] InitArray()
{
    float[] result = new float[4];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(0, 100);
    }

    return result;
}


void PrintArray(float[] array)
{
    for (float i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[(int)i]}, ");
    }
    Console.WriteLine();
}

float[] arr = InitArray();
PrintArray(arr);

float minArr = arr.Min();
float maxArr = arr.Max();

float diff = maxArr - minArr; 


Console.WriteLine($"Difference between maximum and minimum array element -> {diff}");