// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] devArray(int[] array1)                            //Метод присваивания случайных значений
{
    for (int count = 0; count < array1.Length; count++)
    {
        array1[count] = new Random().Next(-100, 101);
    }

    return array1;
}

int summEven(int[] array2)                              //Метод подсчёта суммы чётных позиций массива
{
    int summ = 0;
    for (int count = 0; count < array2.Length; count++)
    {
        if (count % 2 == 1)
        {
            summ = summ + array2[count];
        }
    }


    return summ;
}



int[] array = new int[4];

devArray(array);
Console.WriteLine(String.Join(" ", array));

Console.WriteLine(summEven(array));