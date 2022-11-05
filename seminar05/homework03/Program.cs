// Написать программу копирования массива

Console.WriteLine ("Введите длину массива: ");
int n = int.Parse (Console.ReadLine() ?? "");

Console.WriteLine("Задайте массив: ");
int [] a = new int [n];
for (int i = 0; i < n; i++)
    a[i] = int.Parse(Console.ReadLine() ?? "");
int[] copy = new int[a.Length];
a.CopyTo(copy, 0);
Console.WriteLine(String.Join(", ", copy));