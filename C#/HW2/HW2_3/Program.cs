﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter number day weeks: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 6 || numberDay == 7)
    {

    Console.WriteLine("Yes");
    
    } 
else if (numberDay > 7)
    {
    
    Console.WriteLine("This number not day weeks");
    
    } 
else 
    {
    Console.WriteLine("No");
    }
    