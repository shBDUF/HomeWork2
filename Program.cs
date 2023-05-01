// Console.WriteLine("Введите трёхзначное число: ");
// int numOne = Convert.ToInt32(Console.ReadLine());
// if((numOne/100)>=1 && (numOne/1000)<1)
// {
//     Console.WriteLine($"Вторая цифра числа {numOne} равна {numOne/10%10}");
// }
// else
// {
//     Console.WriteLine("Это не трёхзначное число");
// }


void weekNumber(int arg)
{
    if (arg >= 1 && arg <= 7)
    {
        if (arg >= 1 && arg <= 5)
        {
            Console.WriteLine("Рабочий день");
        }
        if (arg >= 6 && arg <= 7)
        {
            Console.WriteLine("Выходной");
        }
    }
    else
    {
        Console.WriteLine("Нет такого дня недели");
    }
}
Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());
weekNumber(num);
