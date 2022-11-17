// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Найти сумму элементов от M до N");
Console.WriteLine();
Console.WriteLine("N = 15");
int N = 15;
Console.WriteLine("M = 31 ");
int M = 31;
int sum = 0;

Console.WriteLine ("Сумма равна: ");
while (N <= M)
{
    sum = sum+N;
    N++;
}
Console.Write(sum);
