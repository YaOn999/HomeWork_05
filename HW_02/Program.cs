// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int EvenSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
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

int[] array = NewMassive(4, -100, 100);
Console.WriteLine($"в массиве [{String.Join(",", array)}]");

int rezult = EvenSum(array);
Console.WriteLine($"сумма элементов, стоящих на нечетных позициях {rezult}");
