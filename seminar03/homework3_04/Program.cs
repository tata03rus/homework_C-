// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите любое натуральное число");
int A = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int result;

while (i<=A)
{
    result = i*i*i;
    if (result % 2 == 0)
    {
        Console.WriteLine(result);
    }
    i++;
}
