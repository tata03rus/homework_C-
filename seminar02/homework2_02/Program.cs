// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Является ли первое число квадратом второго?");
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
if (a==b*b)
    Console.Write("Первое число является квадратом второго");
else
Console.Write("Первое число НЕ является квадратом второго");