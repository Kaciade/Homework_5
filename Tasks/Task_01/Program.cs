// Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("y = k1 * x + b1\ny = k2 * x + b2");
Console.WriteLine();

Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();
Console.WriteLine($"y = ({k1}) * x + ({b1})\ny = ({k2}) * x + ({b2})");
Console.WriteLine();

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");
Console.WriteLine();