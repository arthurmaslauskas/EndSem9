// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;
using static System.Console;
Clear();

WriteLine($"Mission. Write programm search sum is natural elemets for M to N: ");
int elements(string massage)
{
    Write(massage);
    int result = Convert.ToInt32(ReadLine());
    return result;
}

int SumOfElements(int n, int m)
{
    if (n == m) return n;
    else
        return SumOfElements(n + 1, m) + n;
}

int n = elements("Input M: ");
int m = elements("Input N: ");

WriteLine(SumOfElements(n, m));