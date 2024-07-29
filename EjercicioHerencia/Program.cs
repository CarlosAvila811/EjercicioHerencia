using EjercicioHerencia;
using System;

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase Geometria
        geometria Geometria = new geometria(5.0, 10.0);

        // Imprimir los resultados de las operaciones
        Geometria.Imprimir();

        // Esperar a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}