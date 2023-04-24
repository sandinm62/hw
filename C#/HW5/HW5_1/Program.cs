// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] devArray (int[] array1)
{
    for (int count = 0; count < array1.Length; count++)
    {
        array1[count] = new Random().Next(100,1000);
    }
    return array1;
}

void counter(int[] arrayCount)
{
    int count = 0;
    for (int i = 0; i < arrayCount.Length; i++)
    {
        
        if (arrayCount[i]%2 == 0)
            count ++;
                   
    }
    Console.WriteLine("Колличество чётных элементов в массиве " + count);
}



int[] array = new int[4];

devArray(array);
Console.WriteLine(string.Join(" ", array));

counter(array);


