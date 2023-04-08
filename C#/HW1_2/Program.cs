//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 79 -> 79
// 22 3 9 -> 22

Console.Write("Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumber;

    if (secondNumber > maxNumber) 
        maxNumber = secondNumber;

    if (thirdNumber > maxNumber)
        maxNumber = thirdNumber;

Console.WriteLine($"Max number: {maxNumber}");
