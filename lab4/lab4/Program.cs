using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ingrese el tamaño de arreglo ");
        int tamaño = int.Parse(Console.ReadLine());
        int[] arreglo = new int[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1}: ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }


        int suma = 0;
        foreach (int elemento in arreglo)
        {
            suma += elemento;
        }


        Console.WriteLine($"La suma de los elementos del arreglo es: {suma}");
        Console.WriteLine($"La cantidad de elementos en el arreglo es: {tamaño}");

        Console.ReadKey();
    }


}
