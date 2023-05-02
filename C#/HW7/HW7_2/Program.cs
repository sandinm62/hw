// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
void printArray(int[,] arrayPrint)
{

    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayPrint[i, j]} ");
        }

        Console.WriteLine();
    }

}




int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
printArray(array);

Console.WriteLine("Выберите позицию которую хотите вывести на экран.");
Console.Write("Введите строку(нумерация начинается с 0): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец(нумерация начинается с 0): ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= array.GetLength(0) && n <= array.GetLength(1))
{
    Console.WriteLine($"Строка номер {m} и столбец номер {n} соответствует числу {array[m, n]}");
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}
