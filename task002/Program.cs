﻿//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("Создаем двумерный массив , заполненный случайными числами.");
Console.WriteLine("В нашем массиве находим строку с наименьшей суммой элементов.");
Console.WriteLine("");
Console.WriteLine("Введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int[,] Matrix = new int[lines, columns];

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

FillArrayRandomNumbers(Matrix);
PrintArray(Matrix);
Console.WriteLine("");

int minsum = 0;
for (int j = 0; j < Matrix.GetLength(1); j++)
{
    minsum = Matrix[0, j] + Matrix[0, j++];
}
int indexLine = 0;

for (int i = 0; i < Matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        sum = sum + Matrix[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов = {indexLine}, сумма элементов в этой строке = {minsum}.");
Console.WriteLine("");