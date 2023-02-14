// Написать программу копирования массива

Console.Write("Хотите ли вы ввести массив самостоятельно (да / нет): ");
string yourself = Console.ReadLine() ?? "0";

if (yourself == "нет")
{
    Console.WriteLine();
    Console.Write("Введите количество элементов массива: ");
    int length = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите левую часть диапазона массива: ");
    int min = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите правую часть диапазона массива: ");
    int max = int.Parse(Console.ReadLine() ?? "0");
    int[] array = new int [length];
    Random random = new Random();
    int[] arrayCopy = new int [length];
    for (int i = 0; i < array.Length; i++) array[i] = random.Next(min, max);
    Console.WriteLine();
    Console.Write("МАССИВ 1:\t");
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}\t");
    Console.WriteLine();
    for (int i = 0; i < arrayCopy.Length; i++) arrayCopy[i] = array[i];
    Console.WriteLine();
    Console.Write("КОПИЯ МАССИВА:\t");
    for (int i = 0; i < arrayCopy.Length; i++) Console.Write($"{arrayCopy[i]}\t");
    Console.WriteLine("\n");
}
else if (yourself == "да")
{
    Console.WriteLine();
    Console.Write("Введите количество элементов массива: ");
    int length = int.Parse(Console.ReadLine() ?? "0");
    int[] array = new int [length];
    int[] arrayCopy = new int [length];
    Console.WriteLine();
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{i} элемент массива: ");
        int number = int.Parse(Console.ReadLine() ?? "0");
        array[i] = number;
    }
    for (int i = 0; i < arrayCopy.Length; i++) arrayCopy[i] = array[i];
    Console.Write("\nКОПИЯ МАССИВА:\t");
    for (int i = 0; i < arrayCopy.Length; i++) Console.Write($"{arrayCopy[i]}\t");
    Console.WriteLine("\n");
}