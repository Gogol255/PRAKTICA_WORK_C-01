### Практическое задание №1. Знакомство с языком программирования С#

## Задача №1

Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Для решения данной задачи начертила блок-схему 
[код](task02/Program.cs)
В отдельной папке task02 написала программу

## Задача №2

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Для решения данной задачи начертила блок-схему (Page-2)
[код](task04/Program.cs)
В отдельной папке task04 написала программу

## Задача №3

Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Для решения данной задачи начертила блок-схему (Page-3)
[код](task06/Program.cs)
В отдельной папке task06 написала программу

## Задача №4

Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

Для решения данной задачи начертила блок-схему (Page-4)
[код](task08/Program.cs)
В отдельной папке task08 написала программу

### Практическое задание №2. Базовые алгоритмы

## Задача №1

Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Решила задачу в папке task10 через конвертацию в строку и обращению к символу
[код](task10/Program.cs)

## Задача №2

Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

Решила задачу в папке task13 способом через остаток от деления.
[код](task13/Program.cs)

## Задача №3

Напишите программу, которая принимает на вход цифру, обозначающую день недели,и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

Решила задачу в папке task15.
[код](task15/Program.cs)

### Практическое задание №3. Базовые алгоритмы (продолжение)

## Задача №1

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

Решила задачу в папке task15.
[код](task18/Program.cs)

## Задача №2

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Решила задачу в папке task15.
[код](task21/Program.cs)

## Задача №3

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Решила задачу в папке task15.
[код](task23/Program.cs)

### Практическое задание №4. Функции

## Задача №1

Напишите программу, которая выводит массив из N элементов,
заполненный нулями и единицами в случайном порядке.
Самое левое число != 0
Данный массив есть двоичное представление десятичного числа
[1,0,1,1,0,1,0,0]
Реализовать перевод двоичного числа в десятичное

Решила задачу в папке task777.
[код](task777/Program.cs)

## Задача №2

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

Решила задачу в папке task027.
[код](task023/Program.cs)

### Практическое задание №5. Функции и одномерные массивы


## Задача №37: 

Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

Решила задачу в папке task37.
[код](task37/Program.cs)

### Практическое задание №6.Одномерные массивы-продрлжение


## Задача №41:

Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4

Решила задачу в папке task41.
[код](task41/Program.cs)

## Задача №43:

Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Решила задачу в папке task43.
[код](task43/Program.cs)

### Практическое задание №7.Двумерные массивы


## Задача №47:

Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Решила задачу в папке task47.
[код](task47/Program.cs)

## Задача №50:

Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Решила задачу в папке task50.
[код](task50/Program.cs)

## Задача №52:

Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Решила задачу в папке task52.
[код](task52/Program.cs)

### Практическое задание №8.Двумерные массивы-продолжение


## Задача №56:

Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Решила задачу в папке task56.
[код](task56/Program.cs)


### Практическое задание №9.Рекурсия


## Задача №64:

Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Решила задачу в папке task64.
[код](task64/Program.cs)


## Задача №66:

Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Решила задачу в папке task66.
[код](task66/Program.cs)

## Задача №68:

Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

Решила задачу в папке task68.
[код](task68/Program.cs)