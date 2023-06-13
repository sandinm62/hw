// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Enter first numbre: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber > secondNumber)
        Console.WriteLine($"Max =  {firstNumber}, Min =  {secondNumber}");
   
    else  
        Console.WriteLine($"Max =  {secondNumber}, Min =  {firstNumber}");  