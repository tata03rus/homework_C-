// Написать программу вычисления функции Аккермана

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine() ?? "");
A(n, m);
static int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n,m);
}
            
            
Console.WriteLine(A(n,m));