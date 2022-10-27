// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] array = new int [10];

static void FillArray (int[] array, int min, int max)
{
    var random = new Random();
    for(int i=0; i<array.Length; i++)
    array [i] = random.Next(100,999);
}

Console.Write("Массив: ");
FillArray(array,100,999);
for (int i=0; i<array.Length; i++)
Console.Write(" " + array[i]);
Console.WriteLine();

Console.Write("Количество четных чисел в массиве:");
int sum1 = 0;
for(int i=0; i<array.Length; i++)
if(array[i]%2==0)
{
    sum1 = sum1 + 1;
}
Console.Write(sum1);
Console.WriteLine();

Console.Write("Количество нечетных чисел в массиве:");
int sum2 = 0;
for(int i=0; i<array.Length; i++)
if(array[i]%2!=0)
{
    sum2 = sum2 + 1;
}
Console.Write(sum2);