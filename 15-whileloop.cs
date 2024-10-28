using System;

namespace EjemplosWhile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Contador que se usará en el bucle while
            int contador = 1;

            // Bucle while que cuenta del 1 al 5
            while (contador <= 5)
            {
                Console.WriteLine("Contador: " + contador);
                contador++; // Incrementa el contador para acercarse al final del bucle
            }

            // Bucle infinito con condición de salida
            int intentos = 0;
            while (true)
            {
                Console.WriteLine("Intento número: " + intentos);
                intentos++;

                if (intentos >= 3) // Salir del bucle después de 3 intentos
                {
                    Console.WriteLine("Se alcanzó el número máximo de intentos.");
                    break;
                }
            }
        }
    }
}
