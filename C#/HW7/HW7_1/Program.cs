// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] fillArray(double[,] arrayNew)
{

    for (int i = 0; i < arrayNew.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNew.GetLength(1); j++)
        {
            arrayNew[i, j] = new Random().Next(-100, 101);
        }
    }
    return arrayNew;
}

void printArray(double[,] arrayPrint)
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




Console.Clear();
Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

fillArray(array);
printArray(array);

