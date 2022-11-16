// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов массива, стоящих на нечетных позициях


Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rndm = new Random();
        array[i] = rndm.Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum = sum + array[i];
    }
    return sum;
}

Random rndm = new Random();
int b = rndm.Next(1, 20);
int[] array = new int[b];

Console.WriteLine($"Массив состоит из случайно сгенерированного числа элементов, равного {b}");

FillArray(array);
PrintArray(array);
int result = FindSum(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {result}");