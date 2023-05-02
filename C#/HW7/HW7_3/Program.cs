// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void avarageArray(int[,] arrayAvarage)
{   
    
    for (int i = 0; i < arrayAvarage.GetLength(1); i++)
    {
        double sum = 0;
        
        for (int j = 0; j < arrayAvarage.GetLength(0); j++)
        {
            sum = sum + arrayAvarage[j, i];
        }
        double avarage = sum / arrayAvarage.GetLength(0); 
        Console.Write("{0:F1}; ", avarage);
    }
}



int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
printArray(array);

avarageArray(array);