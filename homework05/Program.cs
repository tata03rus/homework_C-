Console.WriteLine ("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Получается ряд:");
int b = a*-1;
if (a > 0)
{
    while (b <= a)
    {
        Console.WriteLine(b);
        b++;
    }
}
else
{
    while (a <= b)
    {
        Console.WriteLine(a);
        a++;
    }
}
