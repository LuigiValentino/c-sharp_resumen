using System;

namespace EjemplosFor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Bucle for que cuenta del 1 al 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Número: " + i);
            }

            // Bucle for que recorre un array
            string[] frutas = { "Manzana", "Banana", "Naranja", "Uva" };
            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("Fruta: " + frutas[i]);
            }
        }
    }
}
