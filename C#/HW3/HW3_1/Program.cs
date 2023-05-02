// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];                                           //массив из пяти ячеек чтобы записать туда остатки от деления на 10
int count = 0;
int divider = 10;                                                   //Обозначил переменную делитель чтобы не было магических чисел в коде
if (number > 9999 && number < 100000)                               //Проверяем что в числе пять знаков
{
    while (count < array.Length)
    {
        array[count] = number % divider;                            //присваем остаток порядковому элементу массива
        number = number / divider;
        
        count++;
    }

    if (array[0] == array[4] && (array[1] == array[3]))             //сравниваем элеменнты массива чтобы вычислить равенство чисел
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