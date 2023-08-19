/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

using System;
using static System.Console;

Clear();

Write("Введите M: ");
int m = int.Parse(ReadLine()!);
Write("Введите N: ");
int n = int.Parse(ReadLine()!);
int temp = m;


WriteLine();
WriteLine(PrintNumbers(m, n));
WriteLine();
PrintSumm(m, n, temp = 0);
string PrintNumbers(int m, int n)
{
    if (m == n)
        return m.ToString();
    return (m + " " + PrintNumbers(m + 1, n));
}

if (m > n)
{
    m = n;
    n = temp;
}

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Write($"Сумма элементов в промежутке = {summ}");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(ReadLine()!);
    return output;
}

