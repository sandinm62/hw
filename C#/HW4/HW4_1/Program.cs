// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double powNumber(int number1, int numberPow1 )
{
    double result = Math.Pow(number1, numberPow1);
    return result;
}



Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter pow: ");
int numberPow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(powNumber(number,numberPow ));