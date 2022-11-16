// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rndm = new Random();
        array[i] = rndm.Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
}

int Number(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Random rndm = new Random();
int b = rndm.Next(1, 20);
int[] array = new int[b];

Console.WriteLine($"Массив состоит из случайно сгенерированного числа элементов, равного {b}");

FillArray(array);
PrintArray(array);
int result = Number(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел = {result}");