Console.WriteLine("Введите трёхзначное число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
if((numOne/100)>=1 && (numOne/1000)<1)
{
    Console.WriteLine($"Вторая цифра числа {numOne} равна {numOne/10%10}");
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}
