﻿// // Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// // 6 -> да
// // 7 -> да
// // 1 -> нет

Console.Write("Введите порядковый номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 5 && day < 8)
{
    Console.WriteLine("это выходной день");
    }

   else if (day > 0 && day < 6)
{
    Console.WriteLine("это рабочий день");
    }
else if (day > 7)
{
    Console.WriteLine("такого дня недели нет, в неделе всего 7 дней");
    }
else if (day <=0)
{
    Console.WriteLine("такого дня недели нет, отсчет начинается с 1");
    }