using System;
using System.Reflection.Metadata;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Виберіть завдання (1-6): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1.Run();
                break;
            case 2:
                Task2.Run();
                break;
            case 3:
                Task3.Run();
                break;
            case 4:
                Task4.Run();
                break;
            case 5:
                Task5.Run();
                break;
            case 6:
                Task6.Run();
                break;
            default:
                Console.WriteLine("Неправильний вибір.");
                break;
        }
    }
}

class Task1
{
    public static void Run()
    {
        Console.Write("Введіть перший член прогресії (a1): ");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть різницю прогресії (d): ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть кількість членів прогресії (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        double sum = (n / 2.0) * (2 * a1 + (n - 1) * d);
        Console.WriteLine($"Сума {n} членів арифметичної прогресії: {sum}");
    }
}

class Task2
{
    public static void Run()
    {
        Console.Write("Введіть довжину першої сторони трикутника (a): ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть довжину другої сторони трикутника (b): ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть довжину третьої сторони трикутника (c): ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine(a == b || a == c || b == c ? "Трикутник є рівнобедреним." : "Трикутник не є рівнобедреним.");
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }
    }
}

class Task3
{
    public static void Run()
    {
        Console.Write("Введіть координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double radiusSquared = 100;
        bool insideCircle = (x * x + y * y) < radiusSquared;
        bool onCircle = (x * x + y * y) == radiusSquared;
        bool belowLines = (y <= Math.Abs(x));
        bool onLine = (y == Math.Abs(x));

        if ((insideCircle && belowLines) || (onCircle && belowLines) || (insideCircle && onLine))
            Console.WriteLine("Так");
        else if (onCircle || onLine)
            Console.WriteLine("На межі");
        else
            Console.WriteLine("Ні");
    }
}

class Task4
{
    public static void Run()
    {
        Console.Write("Введіть тип фігури (к - коло, п - прямокутник, т - трикутник): ");
        char type = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (type)
        {
            case 'к':
                Console.Write("Введіть радіус кола (r): ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Периметр: {2 * Math.PI * r:F2}");
                Console.WriteLine($"Площа: {Math.PI * r * r:F2}");
                break;
            case 'п':
                Console.Write("Введіть довжину (a): ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть ширину (b): ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Периметр: {2 * (a + b):F2}");
                Console.WriteLine($"Площа: {a * b:F2}");
                break;
            case 'т':
                Console.Write("Введіть сторони трикутника a, b, c: ");
                double ta = Convert.ToDouble(Console.ReadLine());
                double tb = Convert.ToDouble(Console.ReadLine());
                double tc = Convert.ToDouble(Console.ReadLine());
                if (ta + tb > tc && ta + tc > tb && tb + tc > ta)
                {
                    double perimeter = ta + tb + tc;
                    double s = perimeter / 2;
                    Console.WriteLine($"Периметр: {perimeter:F2}"); ;
                    Console.WriteLine($"Площа: {Math.Sqrt(s * (s - ta) * (s - tb) * (s - tc)):F2}");
                }
                else
                    Console.WriteLine("Трикутник не існує");
                break;
            default:
                Console.WriteLine("Невідомий тип фігури.");
                break;
        }
    }
}

class Task5
{
    public static void Run()
    {
        Console.Write("Введіть перше число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Куб різниці: {Math.Pow(a - b, 3)}");
    }
}

class Task6
{
    public static void Run()
    {
        Console.Write("Введіть значення a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть значення b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if (a * a + b * b == 0)
        {
            Console.WriteLine("Ділення на нуль неможливе!");
            return;
        }
        double result = ((a * b + (a - b) * (a + b) - 1) / (a * a + b * b)) - 5;
        Console.WriteLine($"Результат: {result}");
    }
}
