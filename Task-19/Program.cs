﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/************************************************************************/
/* Метод разворачивает любое натуральное число                          */
/************************************************************************/
int TurnOverTheNumber(int param)
{
    int newDig = 0;
    while (param > 9)
    {
        newDig += param % 10;
        newDig *= 10;
        param /= 10;
    }
    newDig += param % 10;
    return newDig;
}

Console.Write("Введите натуральное пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int numRev = TurnOverTheNumber(num);
    if (num == numRev)
        Console.WriteLine($"Число {num} является палиндромом!");
    else
        Console.WriteLine($"Число {num} НЕ является палиндромом!");
}
else
    Console.WriteLine($"Число {num} не является натуральным!");
