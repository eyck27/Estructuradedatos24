//ejercicio 1
using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Ingrese el primer número:");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        float num2 = float.Parse(Console.ReadLine());

        
        float suma = num1 + num2;
        float resta = num1 - num2;
        float multiplicacion = num1 * num2;

        float division;
        if (num2 != 0)
            division = num1 / num2;
        else
            division = 0; 

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
    }
}
//ejercicio 2
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número:");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine(num + " es un número par.");
        }
        else
        {
            Console.WriteLine(num + " es un número impar.");
        }
    }
}

//ejercicio 3
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la base del triángulo:");
        float baseTriangulo = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del triángulo:");
        float alturaTriangulo = float.Parse(Console.ReadLine());

        float areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

        Console.WriteLine("El área del triángulo es: " + areaTriangulo);
    }
}

//ejercicio 4
using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Ingrese un número para calcular su factorial:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("El factorial de " + num + " es: " + Factorial(num));
    }
}

//ejercicio 5
using System;

class Program
{
    static bool EsPrimo(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese un número para verificar si es primo:");
        int num = int.Parse(Console.ReadLine());

        if (EsPrimo(num))
            Console.WriteLine(num + " es un número primo.");
        else
            Console.WriteLine(num + " no es un número primo.");
    }
}

//ejercicio 6
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string cadena = Console.ReadLine();

        char[] caracteres = cadena.ToCharArray();
        Array.Reverse(caracteres);
        string cadenaInvertida = new string(caracteres);

        Console.WriteLine("La cadena invertida es: " + cadenaInvertida);
    }
}

//ejercicio 7
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de inicio del rango:");
        int inicio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número final del rango:");
        int fin = int.Parse(Console.ReadLine());

        int suma = 0;
        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }

        Console.WriteLine("La suma de los números pares en el rango [" + inicio + ", " + fin + "] es: " + suma);
    }
}

//ejercicio 8
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lista de los cuadrados de los primeros 10 números naturales:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + "^2 = " + (i * i));
        }
    }
}

//ejercicio 9
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string cadena = Console.ReadLine();

        int contador = 0;
        foreach (char c in cadena.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                contador++;
            }
        }

        Console.WriteLine("El número de vocales en la cadena es: " + contador);
    }
}

//ejercicio 10
using System;

class Program
{
    static void Main()
    {
        int n = 10; // Cambiar el valor de 'n' para generar más o menos números de la serie Fibonacci
        int primero = 0, segundo = 1, siguiente;

        Console.WriteLine("Los primeros " + n + " números de la serie Fibonacci son:");
        Console.Write(primero + " " + segundo + " ");

        for (int i = 2; i < n; i++)
        {
            siguiente = primero + segundo;
            Console.Write(siguiente + " ");
            primero = segundo;
            segundo = siguiente;
        }

        Console.WriteLine();
    }
}

//ejercicio 11
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de números a ordenar:");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];
        Console.WriteLine("Ingrese los " + n + " números separados por espacio:");
        string[] valores = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            numeros[i] = int.Parse(valores[i]);
        }

        Array.Sort(numeros);

        Console.Write("Los números ordenados de menor a mayor son: ");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

//ejercicio 12
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        string palabraInvertida = "";
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabraInvertida += palabra[i];
        }

        if (palabra.ToLower() == palabraInvertida.ToLower())
        {
            Console.WriteLine("La palabra " + palabra + " es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra " + palabra + " no es un palíndromo.");
        }
    }
}

//ejercicio 13
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabla de multiplicar del " + numero + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}

//ejercicio 14
using System;

class Program
{
    static void Main()
    {
        const double PI = 3.14159265358979323846;

        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = double.Parse(Console.ReadLine());

        double area = PI * radio * radio;

        Console.WriteLine("El área del círculo es: " + area);
    }
}

//ejercicio 15
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero:");
        int numero = int.Parse(Console.ReadLine());

        int suma = 0;
        while (numero != 0)
        {
            suma += numero % 10;
            numero /= 10;
        }

        Console.WriteLine("La suma de los dígitos del número es: " + suma);
    }
}













