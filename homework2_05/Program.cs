// Найти расстояние между точками в пространстве 2D
Console.WriteLine("Введите координаты точек Х1, У1, Х2, У2");
Console.Write("Х1 = ");
int x1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Y1 = ");
int y1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Х2 = ");
int x2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Y2 = ");
int y2 = int.Parse(Console.ReadLine() ?? "0");

double d = Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2);
d = Math.Sqrt (d);
Console.WriteLine(d);

// Найти расстояние между точками в пространстве 3D
Console.WriteLine("Введите координаты точек Х1, У1, Z1, Х2, У2, Z2");
Console.Write("Х1 = ");
int x_1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Y1 = ");
int y_1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Z1 = ");
int z_1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Х2 = ");
int x_2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Y2 = ");
int y_2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Z2 = ");
int z_2 = int.Parse(Console.ReadLine() ?? "0");

double d3d = Math.Pow((x_2-x_1),2)+Math.Pow((y_2-y_1),2)+Math.Pow((z_2-z_1),2);
d3d = Math.Sqrt (d3d);
Console.WriteLine(d3d);