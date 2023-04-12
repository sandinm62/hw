
//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
                
int numberCopy = number;
int count = 0;
if (number > 99)
{
                    
                    
                    
    while (number > 0)                              //считаем количество чисел
    {
                        
        number = number / 10;
        count++;
                        
                        
    }

}
                
    Console.WriteLine(count);

        int[] array = new int[count];               // создаём массив размер которого равен количеству цыфр в числе
        int countArray = 0;
        while (numberCopy > 0)                      
        {
            array[countArray] = numberCopy % 10;    //присваиваем порядковому элементу массива остаток от числа при делении на 10
            numberCopy /= 10;                       // делим число на 10 чтобы убрать остаток
                    
                    
            countArray++;
        }
        
Console.Write(array[array.Length - 3] );            // т.к. в массиве у нас число перевёрнуто выводим третий элемент с конца который у нас в оригинале в числа стоит вначале 

