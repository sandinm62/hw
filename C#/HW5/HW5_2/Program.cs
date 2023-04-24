// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] devArray(int[] array1)
{
    for (int count = 0; count < array1.Length; count++)
    {
        array1[count] = new Random().Next(-100, 101);
    }

    return array1;
}





int array = new int[4];

devArray(array);
