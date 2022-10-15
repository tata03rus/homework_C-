Console.WriteLine("Введите натуральное число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число");
int b = int.Parse(Console.ReadLine());
int c;
if (a%b==0)
    {
        Console.WriteLine("Первое число кратно второму!");
    }
    else
    {
        c = a%b;
        Console.WriteLine(c);
    }