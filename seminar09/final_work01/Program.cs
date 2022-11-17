Console.WriteLine("Показать натуральные числа от M до N");
Console.WriteLine();
Console.Write("N = ");
int N = int.Parse (Console.ReadLine() ?? "");
Console.Write("M = ");
int M = int.Parse (Console.ReadLine() ?? "");

Console.WriteLine ("Получаем ряд: ");
while (N < M)
{
    Console.Write(N + " ");
    N++;
}
while (N >= M)
{
    Console.Write(M + " ");
    M++;
}