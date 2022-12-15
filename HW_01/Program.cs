// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int EvenNumber(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) amount = amount + 1;
    }
    return amount;
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

int[] array = NewMassive(10, 100, 999);
Console.WriteLine($"в массиве [{String.Join(",", array)}]");

int rezult = EvenNumber(array);
Console.WriteLine($"{rezult} четных чисел");