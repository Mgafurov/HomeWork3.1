/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение переменной X:");
        double x = double.Parse(Console.ReadLine());

        double result;

        if (x <= 3)
        {
            result = x * x - 3 * x + 9;
        }
        else
        {
            result = 1 / (Math.Pow(x, 3) - 6);
        }

        Console.WriteLine("Результат: " + result);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение переменной X:");
        double x = double.Parse(Console.ReadLine());

        double result;

        if (x >= 3)
        {
            result = -Math.Pow(x, 2) + 3 * x + 9;
        }
        else
        {
            result = 1 / (Math.Pow(x, 3) - 6);
        }

        Console.WriteLine("Результат: " + result);
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение X: ");
        double x = double.Parse(Console.ReadLine());
        double result;
        if(x <= 7)
        {
            result = -3 * x + 9;
        }
        else
        {
            result = 1 / (Math.Pow(x, 2) - 7);
        }
        Console.WriteLine("Результат: " +result);
        Console.ReadKey();
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());
        double result;
        if (x <=7)
        {
            result = 3 * x - 9;
        }
        else
        {
            result = 1 / (Math.Pow(x, 2) - 4);
        }
        Console.WriteLine("Результат: " +result);
        Console.ReadKey();
    }
}*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение X: ");
        double x = double.Parse(Console.ReadLine());
        double result;
        if(x >= -3.5)
        {
            result = 4 * Math.Pow(x, 2) + 2 - 19;
        }
        else
        {
            result = -2 * x / (-4 * x + 1);
        }
        Console.WriteLine("Результат: " + result);
        Console.ReadKey();
    }
}