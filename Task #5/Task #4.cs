﻿// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());


if (a % 7 == 0 & a % 23 == 0)
{
    Console.WriteLine("Число " + a + " кратно и 23 и 7" );
}
else
{
    Console.WriteLine("Число " + a + " не кратно и 23 и 7" );
}


