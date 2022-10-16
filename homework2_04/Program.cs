// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine() ?? "0");
string str = Convert.ToString(a);
if (a > 9999 && a < 100000)
        if (str[0] == str[4] && str[1] == str[3])
    Console.WriteLine("Введеное число является палиндромом");
else
Console.WriteLine("Введеное число НЕ является палиндромом");