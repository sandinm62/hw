// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];
int count = 0;
int divider = 10;
if (number > 9999 && number < 100000)
{
    while (count < array.Length)
    {
        array[count] = number % divider;
        number = number / divider;
        
        count++;
    }

    if (array[0] == array[4] && (array[1] == array[3]))
    {
        Console.WriteLine("Полиндром ");
    }
    else
    {
        Console.WriteLine("Не является полиндромом ");
    }

}
else
{
    Console.WriteLine("Вы ввевили число не равное пяти знакам ");
}