// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.WriteLine("Введите число m : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n : ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = Convert.ToDouble(new Random().Next(1, 100)) / 10;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Введите число: ");
int f = Convert.ToInt32(Console.ReadLine());
if (m >= array.GetLength(0) || n >= array.GetLength(1))
    Console.WriteLine("такого числа в массиве нет");
else
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов m : ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, j] = new Random().Next(0, 10);
        System.Console.Write($"{array[i, j]} ");
        average = (average + array[i, j]);
    }
    average = average / m;
    Console.Write($"среднее арифметическое столбца равно : {average} ");
    Console.WriteLine();
}
