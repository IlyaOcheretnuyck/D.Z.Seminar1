﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = number*number;
Console.WriteLine("Квадрат числа = " + result);