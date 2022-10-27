// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int [] array = new int [123];

static void FillArray (int[] array, int min, int max)
{
    var random = new Random();
    for(int i=0; i<array.Length; i++)
    array [i] = random.Next(0,1000);
}

Console.Write("Массив: ");
FillArray(array,0,1000);
for (int i=0; i<array.Length; i++)
Console.Write(" " + array[i]);
Console.WriteLine();

Console.Write("Количество элементов из отрезка [10,99]:");
int sum1 = 0;
for(int i=0; i<array.Length; i++)
if(array[i]>=10)
if(array[i]<=99)
{
    sum1 = sum1 + 1;
}
Console.Write(sum1);
Console.WriteLine();