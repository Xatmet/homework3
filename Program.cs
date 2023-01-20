// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
//  от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int Nat(int num)
{
    if (num == 1)
    {
        return 1;
    }
    Console.Write(num);
    return Nat(num - 1);
}
int x = Nat(num);
Console.WriteLine(x);


// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
// //  от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

Console.WriteLine("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum(int M, int N)
{
    if (N == M)
    {
        return M;
    }
    return N + Sum(M, N - 1);
}
int x = Sum(M, N);
Console.WriteLine(x);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа
//  m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());
int Ackerzman(int N, int M)
{
    if (N == 0)
    {
        return M + 1;
    }
    else if (M == 0)
    {
        return Ackerzman(N - 1, 1);
    }
    else return Ackerzman(N - 1, Ackerzman(N, M - 1));
}
int x = Ackerzman(M, N);
Console.WriteLine(x);