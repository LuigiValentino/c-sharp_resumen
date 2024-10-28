using System;

namespace inputs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Se usar Console.ReadLine() para los inputs

            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
        }
    }
}