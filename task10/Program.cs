﻿// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string str = a.ToString();

if(str.Length >2)
{
  Console.WriteLine(str[1]);
}
