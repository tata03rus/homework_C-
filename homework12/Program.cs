Console.WriteLine ("Введите число");
string i;
int a = int.Parse(Console.ReadLine());
if (a > 99)
{
    i = a.ToString();
    Console.WriteLine(i[2]);
}
    else
    {
    Console.WriteLine ("Третьей цифры нет");
    }