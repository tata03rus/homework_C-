// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int [] arr = new int [6];

static void FillArray (int [] arr, int min, int max)
{
    var random = new Random ();
    for(int i = 0; i < arr.Length; i++)
    arr [i] = random.Next(0,10);
}

static void PrintArray (int [] arr)
{
    foreach (int x in arr)
    Console.Write($"{x} ");
    Console.WriteLine();
}

Console.Write("Массив: ");
FillArray(arr,0,10);
PrintArray(arr);

Console.Write("Произведение пар чисел равно: ");
int count = 0;
int N = arr.Length/2;
for (int i = 0; i < arr.Length; i++) // нахожу сколько элементов будет содержаться и передавться в массив
{
    if (i < N)
    {
        count++;
    }
}
int[] arr2 = new int[count]; //создаю массив
int j = 0;
for(int i = 0; i < N; i++)
if (j < arr2.Length)
{
    arr2 [j] = arr[i] * arr[arr.Length - i -1];
    j++;
}
foreach (int y in arr2)
    Console.Write($"{y} ");
    Console.WriteLine();
