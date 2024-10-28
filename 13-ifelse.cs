using System;

namespace ifelse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variables de ejemplo
            int temperatura = 30; // Representa la temperatura en grados
            int edad = 17;        // Representa la edad de una persona

            // Ejemplo de if simple
            // Verifica si la temperatura es mayor a 25 grados
            if (temperatura > 25)
            {
                Console.WriteLine("Hace calor hoy.");
            }
            // Si la condición es falsa (temperatura <= 25), este bloque se omite

            // Ejemplo de if-else
            // Verifica si la persona es mayor o igual a 18 años
            if (edad >= 18)
            {
                Console.WriteLine("La persona es mayor de edad.");
            }
            else
            {
                Console.WriteLine("La persona es menor de edad.");
            }
            // Si la condición es verdadera (edad >= 18), ejecuta el bloque del if.
            // Si es falsa, se ejecuta el bloque del else.

            // Ejemplo de if-else con condiciones adicionales (if-else if-else)
            int hora = 15; // Representa la hora en formato de 24 horas

            if (hora < 12)
            {
                Console.WriteLine("Buenos días.");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Buenas tardes.");
            }
            else
            {
                Console.WriteLine("Buenas noches.");
            }
            // Aquí, el programa evalúa cada condición en orden:
            // - Si hora < 12, muestra "Buenos días."
            // - Si no, evalúa si hora < 18 y muestra "Buenas tardes."
            // - Si ninguna de las anteriores es verdadera, muestra "Buenas noches."
        }
    }
}
