// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int [] array = new int [12];

static void FillArray (int[] array, int min, int max)
{
    var random = new Random();
    for(int i=0; i<array.Length; i++)
    array [i] = random.Next(-9,9);
}

Console.Write("Массив: ");
FillArray(array,-9,9);
for (int i=0; i<array.Length; i++)
Console.Write(" " + array[i]);
Console.WriteLine();

Console.Write("Сумма чисел массива:");
int sum = 0;
for(int i=0; i<array.Length; i++)
sum = sum +array[i];
Console.Write(sum);
