﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int AccerFunk(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return AccerFunk(n - 1, 1);
    else return AccerFunk(n - 1, AccerFunk(n, m - 1));
}
Console.WriteLine(AccerFunk(3,2));