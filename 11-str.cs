using System;

namespace str
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // metodos relacionados a los string

            //length
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);


            Console.WriteLine(txt.ToUpper());   // Outputs "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Console.WriteLine(txt.ToLower());   // Outputs "abcdefghijklmnopqrstuvwxyz"


            string firstName = "John ";
            string lastName = "Doe";
            // se pueden hacer "sumas" con +

            string name = firstName + lastName;
            Console.WriteLine(name);

            // string.Concat() para contactenar 2 string

            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            //interpolaciones de textos
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            //valores y busquedas en strings
            string myString = "Hello";
            Console.WriteLine(myString[0]);  // Outputs "H"
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            // Full name
                string name = "John Doe";

                // Location of the letter D
                int charPos = name.IndexOf("D");

                // Get last name
                string lastName = name.Substring(charPos);

                // Print the result
                Console.WriteLine(lastName);
        }
    }
}