// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day % 7 > 0 & day % 7 <= 5)
{
  Console.WriteLine("Будний день");
}
else
{
  Console.WriteLine("Выходной день");
}