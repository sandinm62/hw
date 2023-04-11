﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

    if (number > 99 && number < 1000)   // проверка того что чило трёхзначное
    {
        int count = number % 100;       // получаем остаток от деления на сотни
        count = count / 10;             // получаем результат деления не десятки
        Console.WriteLine(count);
    }
    else
    {
        Console.WriteLine("Вы ввели не трёхзначное число");
    }

