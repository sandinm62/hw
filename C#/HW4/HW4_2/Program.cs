// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sum(int numberSum)
{
    int result = 0;

    while (numberSum > 0)
    {
        result = result + (numberSum % 10);
        numberSum = numberSum / 10;
    }

    return result;
}

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sum(number));

