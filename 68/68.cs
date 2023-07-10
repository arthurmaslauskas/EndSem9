// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;
Clear();

WriteLine($"Function Akkerman: ");
int Akkerman1(string message)
{
    Write(message);
    int result = Convert.ToInt32(ReadLine());
    return result;
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Akkerman1("Input M: ");
int n = Akkerman1("Input N: ");

WriteLine($"A({m},{n})= {Akkerman(m, n)}");