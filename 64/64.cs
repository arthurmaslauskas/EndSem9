// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;
Clear();

WriteLine($"Write Natural elements: ");
int Natural(string message)
{
    Write(message);
    int result = Convert.ToInt32(ReadLine());
    return result;
}

int NaturalNumber(int n, int m)
{
    if (n == m) return n;
    else
        Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int n = Natural("Input N: ");
if (n < 1)
{
    WriteLine("Wrute true number:");
    return;
}
WriteLine(NaturalNumber(n, 1));