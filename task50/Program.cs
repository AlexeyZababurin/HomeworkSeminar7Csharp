// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void CheckElementMassive(int[,] massive)
{
    int n = GetInput("Введите номер искомого элемента в массиве: ");
    int columnIndex = n % massive.GetLength(1) - 1;
    int rowIndex = n / massive.GetLength(1);
    if (n > massive.GetLength(0) * massive.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else if (n % massive.GetLength(1) == 0)
    {
        columnIndex = massive.GetLength(1) - 1;
        rowIndex = n / massive.GetLength(1) - 1;
    }
    Console.WriteLine($"Искомый элемент равен: {massive[rowIndex, columnIndex]}");
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
CheckElementMassive(massive);
