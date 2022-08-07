//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.WriteLine($"Создаем двумерный массив , заполненный случайными числами.");
Console.WriteLine($"Упорядочиваем по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("");
Console.WriteLine("Введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");


int[,] Matrix = new int[lines, columns];

void FillingArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

void SorttedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (Matrix[i, k] < Matrix[i, k + 1])
                {
                    int temp = 0;
                    temp = Matrix[i, k];
                    Matrix[i, k] = Matrix[i, k + 1];
                    Matrix[i, k + 1] = temp;
                }
            }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine($"Несортированный массив : ");
    for (int i = 0; i < array.GetLength(0); i++)
    {

        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString().PadLeft(4) + " | ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void PrintSortedArray(int[,] array)
{
    Console.WriteLine("");
    Console.WriteLine($"Cортированный массив : ");
    for (int i = 0; i < array.GetLength(0); i++)
    {

        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString().PadLeft(4) + " | ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
FillingArrayRandomNumbers(Matrix);
PrintArray(Matrix);
SorttedArray(Matrix);
PrintSortedArray(Matrix);