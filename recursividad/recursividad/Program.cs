//1
using System;

class Program
{
    static void PrintEvenNumbers(int start, int end)
    {
        if (start > end)
            return;

        if (start % 2 == 0)
            Console.WriteLine(start);

        PrintEvenNumbers(start + 1, end);
    }

    static void Main(string[] args)
    {
        PrintEvenNumbers(1, 100);
    }
}

//2
using System;

class Program
{
    static int SumNumbers(int n)
    {
        if (n == 1)
            return 1;

        return n + SumNumbers(n - 1);
    }

    static void Main(string[] args)
    {
        int n = 10; // Puedes cambiar este valor
        Console.WriteLine("La suma de los números del 1 al " + n + " es: " + SumNumbers(n));
    }
}

//3
using System;

class Program
{
    static void PrintPyramid(int n)
    {
        if (n == 0)
            return;

        PrintPyramid(n - 1);

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int n = 5; // Puedes cambiar este valor
        PrintPyramid(n);
    }
}

//4
using System;

class Program
{
    static void PrintInvertedPyramid(int n)
    {
        if (n == 0)
            return;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        PrintInvertedPyramid(n - 1);
    }

    static void Main(string[] args)
    {
        int n = 5; // Puedes cambiar este valor
        PrintInvertedPyramid(n);
    }
}

//5
using System;

class Program
{
    static void PrintMultiplicationTable(int n, int multiplier)
    {
        if (multiplier > 10) // Imprimir hasta el 10
            return;

        Console.WriteLine(n + " * " + multiplier + " = " + (n * multiplier));

        PrintMultiplicationTable(n, multiplier + 1);
    }

    static void Main(string[] args)
    {
        int n = 5; // Tabla de multiplicar del 5
        PrintMultiplicationTable(n, 1);
    }
}
