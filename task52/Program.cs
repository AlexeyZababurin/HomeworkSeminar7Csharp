// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticAverageOfColumns(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < massive.GetLength(0); j++)
        {
            sum += massive[j, i];
        }
        Console.Write($"{Math.Round(sum / massive.GetLength(0), 1)}\t");
    }
}

void Print2DMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Задайте количество строк массива: ");
int n = GetInput("Задайте количество столбцов массива: ");
int[,] massive = Create2DMassive(m, n, 10, 100);
Console.WriteLine("Сгенерирован двумерный массив");
Print2DMassive(massive);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца");
ArithmeticAverageOfColumns(massive);
