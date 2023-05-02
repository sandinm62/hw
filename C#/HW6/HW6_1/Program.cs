// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int enterNumber(string str)
{
    int count = 0;
    while (str != "exit")
    {
        str = Console.ReadLine();
        str.ToLower();
        
        if (str == "exit")
        break;

        int num = Convert.ToInt32(str);
        if (num > 0)
        {
            count ++;
        }
    }
    Console.WriteLine(count);
    return count;

}

Console.Clear();
Console.WriteLine("Вводите числа, после каждого числа нажимайте Enter.\nДля окончания ввода наберите Exit");

string number = " ";
enterNumber(number);


