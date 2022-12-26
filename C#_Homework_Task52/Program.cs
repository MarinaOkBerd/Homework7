// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] numbers = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};



for (int i = 0; i < numbers.GetLength(1); i++)
{
    double summ = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        summ += numbers[j, i];
    }
    Console.Write(Math.Round(summ / numbers.GetLength(0), 1) + "; ");
}