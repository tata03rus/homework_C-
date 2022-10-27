Console.WriteLine ("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
if (a < 1000)
{
    if (a > 99)
    {
        Console.WriteLine (a%10);
    }
    else
    {
    Console.WriteLine ("ОШИБКА");
    }
}
else
    {
    Console.WriteLine ("ОШИБКА");
    }

