Console.WriteLine("Пусть 1 - понедельник, 2 - вторник, 3 -среда, 4 - четверг, 5 - пятница, 6 - суббота, а 7 - пятница.");
Console.WriteLine("Введите число, обозначаюшее день недели");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a == 6 || a == 7)
    {
        Console.WriteLine("Выходной день");
    }
else
Console.WriteLine("Будний день");