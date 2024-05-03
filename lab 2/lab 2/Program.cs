using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese dos números
        Console.WriteLine("Ingrese el primer número:");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        float num2 = float.Parse(Console.ReadLine());

        // Realizar operaciones
        float suma = num1 + num2;
        float resta = num1 - num2;
        float multiplicacion = num1 * num2;

        // Verificar si el segundo número es diferente de cero antes de realizar la división
        float division;
        if (num2 != 0)
            division = num1 / num2;
        else
            division = 0; // División por cero, asignar 0

        // Mostrar resultados
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
    }
}

