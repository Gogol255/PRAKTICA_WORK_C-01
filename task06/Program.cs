﻿//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = number % 2;

if(a == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}

