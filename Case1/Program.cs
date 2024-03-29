﻿// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
//  Aₙₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4. 0 1 23
// 1 2 34
// 2 3 45

Console.WriteLine("Введите m - ");
bool checkM = int.TryParse(Console.ReadLine(), out  int m);
Console.WriteLine("Введите n - ");
bool checkN = int.TryParse(Console.ReadLine(), out  int n);

if (!checkM || !checkN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m,n);
Print2DArray(array);

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random  = new Random ();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
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