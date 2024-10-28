using System;

namespace EjemplosBreakContinue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Bucle for con break
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Se alcanzó el valor 5, saliendo del bucle.");
                    break; // Sale del bucle cuando i es igual a 5
                }
                Console.WriteLine("Número: " + i);
            }

            // Bucle for con continue
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Salta los números pares
                }
                Console.WriteLine("Número impar: " + i);
            }
        }
    }
}
