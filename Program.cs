//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х первой точки: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х второй точки: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.Write(Math.Round(result, 2));

//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int index = 0; index < num; index++)
{
    array[index] = (index + 1) * (index + 1) * (index + 1);

    Console.Write($"{array[index]} ");
}


// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Веедите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];
for (int i = 0; i < 5; i++)
{
    array[i] = num % 10;
    Console.WriteLine($"{array[i]}");
    num = num / 10;
}
if (array[0] == array[4] && array[1] == array[3])
    Console.Write("Число является палиндромом");
else
    Console.Write("Число Не является палиндромом");