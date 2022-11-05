// Написать программу масштабирования фигуры

Console.WriteLine("Задайте вершины фигуры:");
Console.Write ("A = ");
int [] A = new int [2];
for (int i = 0; i < 2; i++)
    A [i] = int.Parse(Console.ReadLine() ?? "");

Console.Write ("B = ");
int [] B = new int [2];
for (int i = 0; i < 2; i++)
    B [i] = int.Parse(Console.ReadLine() ?? "");

Console.Write ("C = ");
int [] C = new int [2];
for (int i = 0; i < 2; i++)
    C [i] = int.Parse(Console.ReadLine() ?? "");


Console.Write ("D = ");
int [] D = new int [2];
for (int i = 0; i < 2; i++)
    D [i] = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Задайте коэффициент масштабирования фигуры:");
int k = int.Parse(Console.ReadLine() ?? "");

for (int i = 0; i < A.Length; i++)
    A [i] = k * A[i];
    Console.Write("A = ");
    foreach (var x in A)
    {
        Console.Write(x.ToString() + ", ");
    }

for (int i = 0; i < B.Length; i++)
    B[i] = k * B[i];
    Console.Write("B = ");
    foreach (var y in B)
    {
        Console.Write(y.ToString() + ", ");
    }

for (int i = 0; i < C.Length; i++)
    C[i] = k * C[i];
    Console.Write("C = ");
    foreach (var z in C)
    {
        Console.Write(z.ToString() + ", ");
    }

for (int i = 0; i < D.Length; i++)
    D[i] = k * D[i];
    Console.Write("D = ");
    foreach (var e in D)
    {
        Console.Write(e.ToString() + ", ");
    }

