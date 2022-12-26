//  47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.WriteLine("Ведите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Convert.ToDouble(new Random().Next(-10,10)) / 10;
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine(" ");
}