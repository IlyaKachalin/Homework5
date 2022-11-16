// Задайте массив из вещественных чисел. Определите разницу между максимальным и минимальным элементами массива

Console.Clear();

Random rnd = new Random();
int b = rnd.Next(1, 11);
Console.WriteLine($"Размер массива равен случайно сгенерированному числу {b}");

double[] array = new double[b];
FillArray(array);
PrintArray(array);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

double x = max - min;
double x1 = Math.Round(x, 1);

Console.WriteLine($"Разница между максимальным и минимальным значением = {x1}");

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * 100;
        array[i] = Math.Round(num, 1);
    }
}
void PrintArray(double[] numbers)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}
