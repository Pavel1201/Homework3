﻿Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Кубы числа {N}: ");
for(int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i,3)} ");


} 