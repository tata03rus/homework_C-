// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Найдите точку пересечения двух прямых, где ");
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine() ?? "");
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine() ?? "");
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine() ?? "");
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine() ?? "");

double x;
double y;

x = (b2 - b1)/(k1 - k2);
y = k1 * x + b1;

Console.WriteLine("x = " + x + ", y = " + y);