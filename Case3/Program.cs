// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 47 2
// 5 92 3
// 8 42 4
//Сумма элементов главной диагонали: 1+9+2 = 12
Console.Clear();
Console.WriteLine("Введите m - ");
bool checkM = int.TryParse(Console.ReadLine(), out  int m);
Console.WriteLine("Введите n - ");
bool checkN = int.TryParse(Console.ReadLine(), out  int n);
int count = 0;
if (!checkM || !checkN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m,n, out count);
Print2DArray(array);
Console.WriteLine($"Сумма всех чисел на главной диагонали - {count}");

int[,] CreateRandom2DArray(int m, int n, out int count)
{
    int[,] array = new int[m, n];
    count = 0;
    Random random  = new Random ();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
            if (i == j)
            {
                count += array[i, j];
            }
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}