// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] massiv)
{
    int size = massiv.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
}


void Method41()
{
    Console.WriteLine("Задача 41!");
    int quantity = Input("Количество чисел, которое будет вводить пользователь: ");
    int[] array = new int[quantity];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Выведем исходные числа!");
    PrintArray(array);
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"{count} - количество положительных чисел!");
}

void Method43()
{
    Console.WriteLine("Задача 43!");
    int b1 = Input("Коэффициент b для первой прямой: ");
    int b2 = Input("Коэффициент b для второй прямой: ");
    int k1 = Input("Коэффициент k для первой прямой: ");
    int k2 = Input("Коэффициент k для второй прямой: ");
    if (k1 != k2)
    {
        Console.Write("Найдем координату х: ");
        double x = (b2 - b1) / (k1 - k2);
        Console.Write($"({b2} - {b1}) / ({k1} - {k2}) = {x}");
        Console.WriteLine();
        double y = k1 * x + b1;
        Console.Write("Найдем координату y: ");
        Console.Write($"{k1}x{x} + {b1} = {y}");
    }
    else if (b1 != b2)
    {
        Console.WriteLine("Прямые параллельны!");
    }
    else if ((b1 == b2) && (k1 == k2))
    {
        Console.WriteLine("Прямые совпадают!");
    }
}


Method41();
Method43();
