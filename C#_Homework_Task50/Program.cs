//  50: вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] numbers = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.WriteLine("Введите позицию элемента в строке");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в столбце");
int y = Convert.ToInt32(Console.ReadLine());

if(x < 0 | x > numbers.GetLength(0) - 1 | y <0 | y > numbers.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента нет.");
}
else
{
    Console.WriteLine(numbers[x,y]);
}
