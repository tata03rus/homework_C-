int max;
Random rnd = new Random(); //Создание объекта для генерации чисел
int a = rnd.Next(10, 99); //Получить случайное число (в диапазоне от 0 до 10)
Console.WriteLine(a); //Вывод числа в консоль
int b = a/10;
int c = a%10;
if (b>c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
Console.WriteLine(max);