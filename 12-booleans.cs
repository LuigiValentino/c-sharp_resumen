using System;

namespace booleans
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Los booleanos en C# son iguales que en todos los lenguajes  TRUE o FALSE
            bool isCSharpFun = true;
            bool isFishTasty = false;
                Console.WriteLine(isCSharpFun);   // Outputs True
                Console.WriteLine(isFishTasty);   // Outputs False


            //Operaciones con booleanos
                int x = 10;
                int y = 9;
                Console.WriteLine(x > y); // returns True, because 10 is higher than 9

            //Ejemplo real
            int myAge = 25;
            int votingAge = 18;

            if (myAge >= votingAge) 
            {
            Console.WriteLine("Old enough to vote!");
            } 
            else 
            {
            Console.WriteLine("Not old enough to vote.");
}
        }
    }
}