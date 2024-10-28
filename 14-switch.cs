using System;

namespace EstructuraSwitch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variable que representa un día de la semana en formato numérico
            int diaSemana = 3; // 1 = Lunes, 2 = Martes, 3 = Miércoles, etc.

            // Usando switch para decidir qué día es
            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("Hoy es Lunes.");
                    break;
                case 2:
                    Console.WriteLine("Hoy es Martes.");
                    break;
                case 3:
                    Console.WriteLine("Hoy es Miércoles.");
                    break;
                case 4:
                    Console.WriteLine("Hoy es Jueves.");
                    break;
                case 5:
                    Console.WriteLine("Hoy es Viernes.");
                    break;
                case 6:
                    Console.WriteLine("Hoy es Sábado.");
                    break;
                case 7:
                    Console.WriteLine("Hoy es Domingo.");
                    break;
                default:
                    Console.WriteLine("Día no válido.");
                    break;
            }

            // Explicación de cada parte:
            // - switch: evalúa la variable `diaSemana`.
            // - case 1: si `diaSemana` es igual a 1, ejecuta este bloque y muestra "Hoy es Lunes."
            // - break: detiene la ejecución del switch después de cada caso.
            // - default: si `diaSemana` no coincide con ningún caso, ejecuta el bloque `default`.

            // Ejemplo adicional usando switch con texto
            string estacion = "verano";

            switch (estacion)
            {
                case "primavera":
                    Console.WriteLine("Es primavera. Las flores están floreciendo.");
                    break;
                case "verano":
                    Console.WriteLine("Es verano. Hace mucho calor.");
                    break;
                case "otoño":
                    Console.WriteLine("Es otoño. Las hojas están cayendo.");
                    break;
                case "invierno":
                    Console.WriteLine("Es invierno. Hace frío.");
                    break;
                default:
                    Console.WriteLine("Estación no reconocida.");
                    break;
            }
        }
    }
}
