// See https://aka.ms/new-console-template for more information
using System;
class Program 
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la aplicacion interactiva");
        Console.Write("Por favor, introduce tu nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Sientete bienvenido, {nombre}!");
        Console.WriteLine("Digita tu edad:");
        float edad = Console.Read();
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else 
        {
            Console.WriteLine("Eres menor de edad");
        }
        //Hay un fallo aqui, digita un numero aleatorio en la puntuacion de forma automatia.
        Console.WriteLine("Digite una puntuacion del 1 al 10:");
        int calidad = Console.Read();
        bool estandar = false;

        Console.WriteLine($"{calidad}");

        if (calidad > 1 && calidad <=10)
        {
            estandar = true;
            
        }
        else
        {
            estandar = false;
        }

        if (estandar==false)
        {
            Console.WriteLine("Variable no valida, digite nuevamente:");
        }

        if (estandar==true)
        {
            if (calidad < 5)
            {
            Console.WriteLine("Necesitas mejorar mas");
            }
            else if (calidad <= 7)
            {
            Console.WriteLine("Buen trabajo, pero hay margen para mejorar");
            }
            else if (calidad <= 10)
            {
            Console.WriteLine("Excelente trabajo!");
            }
        }
        Console.WriteLine("Presione una tecla para salir");
        Console.ReadKey();
    }
}
