﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string massage)
{
    System.Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}

int n = ReadInt("Введите число");
System.Console.WriteLine($"Таблица кубов числа {n}");
for (int i = 1; i <= n; i++)
{
    int res = i * i * i;
    Console.Write($"{res}, ");
}
