// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int EvenSum(int[] array)
{
    int min = array[0];
    int max = array[0];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    int rezult = max - min;
    return rezult;
}

int[] NewMassive(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max++);
    }
    return array;
}

int[] array = NewMassive(4, 0, 100);
Console.WriteLine($"в массиве [{String.Join(",", array)}]");

int rezult = EvenSum(array);
Console.WriteLine($"разница между максимальным и минимальным элементом массива {rezult}");