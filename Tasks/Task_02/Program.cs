// Написать программу масштабирования фигуры

Console.Write("Введите количество углов в вашей фигуре: ");
int quantOfAng = int.Parse(Console.ReadLine() ?? "0");
int[] arrayX = new int [quantOfAng];
int[] arrayY = new int [quantOfAng];
int[] arrayXCopy = new int [quantOfAng];
int[] arrayYCopy = new int [quantOfAng];
Console.Write("Введите целочисленный коэффициент масштабирования фигуры: ");
int k = int.Parse(Console.ReadLine() ?? "0");

for (int i = 0; i < quantOfAng; i++)
{
    Console.WriteLine($"Введите координаты {i+1}-го угла: ");
    Console.Write("    x: ");
    arrayX[i] = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("    y: ");
    arrayY[i] = int.Parse(Console.ReadLine() ?? "0");
}
for (int i = 0; i < quantOfAng; i++) arrayXCopy[i] = arrayX[i] * k;
for (int i = 0; i < quantOfAng; i++) arrayYCopy[i] = arrayY[i] * k;
Console.WriteLine("Начальные координаты:");
for (int i = 0; i < quantOfAng; i++) Console.Write($"({arrayX[i]}; {arrayY[i]})  ");
Console.WriteLine("\nКоординаты после масштабирования:");
for (int i = 0; i < quantOfAng; i++) Console.Write($"({arrayXCopy[i]}; {arrayYCopy[i]})  ");
