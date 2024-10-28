using System;

namespace EjemplosArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declaración y asignación de un array
            int[] numeros = { 1, 2, 3, 4, 5 };

            // Accediendo a elementos del array
            Console.WriteLine("Primer elemento: " + numeros[0]);  // Muestra 1
            Console.WriteLine("Último elemento: " + numeros[numeros.Length - 1]); // Muestra 5

            // Modificando un elemento del array
            numeros[2] = 10; // Cambia el tercer elemento a 10
            Console.WriteLine("Nuevo valor en el índice 2: " + numeros[2]); // Muestra 10

            // Recorrer el array con foreach
            Console.WriteLine("Recorriendo el array:");
            foreach (int numero in numeros)
            {
                Console.WriteLine("Número: " + numero);
            }

            // Array de strings y uso de métodos
            string[] nombres = new string[3];
            nombres[0] = "Carlos";
            nombres[1] = "Ana";
            nombres[2] = "Luis";

            Array.Sort(nombres); // Ordena el array en orden alfabético
            Console.WriteLine("Nombres ordenados:");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
