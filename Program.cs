﻿//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]



Console.WriteLine("Введите число: ");
int num  = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0,100);
    Console.Write($"{array[i]} ");
  Console.WriteLine();
}


//Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum= 0;
while (i > 0 )
{
  int num = i % 10;
i = i / 10;
sum= sum + num;
}
Console.WriteLine( sum );




//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число: A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: B ");
int B = Convert.ToInt32(Console.ReadLine());
int degr = A;
for (int i = 1; i < B; i++)
{
degr = degr * A;
}
Console.WriteLine(degr);