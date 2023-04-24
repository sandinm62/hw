// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] devArray(int[] array1)
{
    for(int count = 0; count < array1.Length; count++)
    {
            array1[count] = new Random().Next(0,101);
    }
    
    return array1;
}

int maxMin(int[] array2)
{
    int min = array2[0];
    int max = array2[0];
    for (int count = 0; count < array2.Length; count++)
    {   
        if (array2[count] > max)
        {
            max = array2[count];
        }
        else if (array2[count] < min)
        {
            min = array2[count];
        }
    }

    int result = max - min;
    return result;
}


int[] array = new int[10];

Console.WriteLine(String.Join(" ", devArray(array)));
Console.WriteLine(maxMin(array));