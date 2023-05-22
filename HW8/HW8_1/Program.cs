// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2





int[,] CreateArray(int[,] arrayMass)
{ 

        for (int i = 0; i < arrayMass.GetLength(0); i++)
        {
            for (int j = 0; j < arrayMass.GetLength(1); j++) 
            {arrayMass[i, j] = new Random().Next(0, 10);}
        }
        return arrayMass;
}

void PrintArray(int[,] array2)
{
    for(int i = 0; i < array2.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i,j] + " ");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите колличество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[m, n];

CreateArray(newArray);
PrintArray(newArray);