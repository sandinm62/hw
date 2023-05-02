// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] devArray(int[] array1)
{
    for (int count = 0; count < array1.Length; count++)
    {
        array1[count] = new Random().Next(1,100);

    } 

    return array1;
    
}



int[] array = new int[8];

devArray(array);

Console.WriteLine(String.Join(" ", array));
