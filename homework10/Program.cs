Console.WriteLine ("Введите трехзначное число");
string i;
int a = int.Parse(Console.ReadLine());
if (a < 1000)
{
    if (a > 99)
    {
        i = a.ToString();
        i = i.Remove(1,1);
        Console.WriteLine(i);
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