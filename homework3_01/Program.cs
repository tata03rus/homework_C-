// Найти кубы чисел от 1 до N
Console.WriteLine("Введите любое натуральное число");
int A = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int result;

while (i<=A)
{
    result = i*i*i;
    Console.WriteLine(result);
    i++;
}