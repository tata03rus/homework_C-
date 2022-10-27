// Подсчитать сумму цифр в числе
Console.WriteLine("Введите любое натуральное число");
int a = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
while (a%10 != 0)
{
    sum = sum + a%10; 
    a = a/10;
}
Console.WriteLine(sum);