//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[10];
System.Console.WriteLine("Введите  трехзначное число:");
int sum = Convert.ToInt32(Console.ReadLine());
int count = 0;
SArray(array);
PrintArray(array);
for (int i = 0; i < array.Length; i++)

    if (array[i] % 2 == 0)
        count++;
System.Console.WriteLine($"всего {array.Length} чисел,{count} из них четные");
void SArray(int[] array)
{
}
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

//void PrintArray(int[] array)
//{
//  System.Console.WriteLine();
//for (int i = 0; i < array.Length; i++)
//{
System.Console.WriteLine();
}
}



// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


System.Console.WriteLine("Введите  число массива:");
int sum = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];
int summa = 0;
Summa(array);
PrintArray();
int Summa(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        System.Console.WriteLine($"{array[i]} ");
        if (array[i] % 2! == 1)
        {
            summa = summa + array[i];
        }
    }
    return summa;
}
void PrintArray()
{
    System.Console.WriteLine($"сумма элементов на нечетных позициях равна:{summa} ");
}


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

System.Console.WriteLine("Введите  число массива:");
int sum = Convert.ToInt32(Console.ReadLine());
double[] array = new double[5];
SArray(array);
PrintArray(array);
double max = Int32.MaxValue;
double min = Int32.MinValue;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);

    System.Console.WriteLine($"{array[i]} ");
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
System.Console.WriteLine($"максимальное значение {max}, минимальное значение {min}");
System.Console.WriteLine($"разниц между максимальным и минимальным значение {max - min}");
void SArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(10, 100)) / 10;
    }
}
void PrintArray(double[] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}




