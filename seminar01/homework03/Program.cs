Console.WriteLine ("Введите три числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if (a > b)
{
    max = a;
}
if (b > c)
{
    max = b;
}
else
{
    max = c;
}
Console.WriteLine(max);