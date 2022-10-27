// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int [] arr = new int [7];
static void FillArray(int [] arr, int min, int max)
{
    var random = new Random();
    for(int i=0; i<arr.Length; i++)
    arr[i] = random.Next(0,10);
}

static void PrintArray (int [] arr)
{
    foreach (int x in arr)
    Console.Write($"{x} ");
    Console.WriteLine();
}

Console.Write("Массив: ");
FillArray(arr,0,1000);
PrintArray(arr);
int sum = 0;
for(int i = 0; i < arr.Length; i++)
if (i % 2 == 0)
{
    
    sum = sum + arr[i];
}
Console.WriteLine(sum);