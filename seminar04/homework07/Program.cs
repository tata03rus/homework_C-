// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int [] array = new int [10];

static void FillArray (int[] array, int min, int max)
{
    var random = new Random();
    for(int i=0; i<array.Length; i++)
    array [i] = random.Next(0,50);
}

Console.Write("Массив: ");
FillArray(array,0,50);
for (int i=0; i<array.Length; i++)
Console.Write(" " + array[i]);
Console.WriteLine();

Console.Write("Максимальное число в массиве:");
int max = array[0];
for(int i=0; i<array.Length; i++)
if(array[i] > max)
{
    max = array[i];
}
Console.Write(max);
Console.WriteLine();

Console.Write("Минимальное число в массиве:");
int min = array[0];
for(int i=0; i<array.Length; i++)
if(array[i] < min)
{
    min = array[i];
}
Console.Write(min);
Console.WriteLine();

Console.Write("Разница между максимальным и минимальным равна " + (max-min));
