﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Таблица кубов чисел: ");

for (int i = 1; i <= n; i++)
{
    System.Console.WriteLine($"{i} --> {i*i*i}");
};

for (int i = 1; i >= n; i--)
{
    System.Console.WriteLine($"{i} --> {i*i*i}");
}