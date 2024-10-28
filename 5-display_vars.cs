using System;

namespace display_vars
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // se debe usar WriteLine() y el operador "+" para sumar la variable al output
            string name = "Luigi";
            Console.WriteLine("Hello " + name);

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); 
        }
    }
}