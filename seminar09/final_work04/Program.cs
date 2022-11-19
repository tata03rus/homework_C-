// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

Console.Write ("Введите длину массива: ");
int n = int.Parse (Console.ReadLine() ?? "");

int [] N = new int [n];
Console.Write("Введите число n: ");
N[0] = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число m: ");
N[1] = int.Parse(Console.ReadLine() ?? "");

for (int i = 2; i < n; i++)
    N[i] = N[i-1]+ N[i-2];
            
Console.WriteLine("Получаем массив: " + string.Join(", ", N));