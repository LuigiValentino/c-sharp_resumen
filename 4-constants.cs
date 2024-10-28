using System;

namespace Constants
{
    public class Program
    {
        //Predefinir vars y obligando a mantener el valor
        public static void Main(string[] args)
        {
            const int myNum = 15;
            myNum = 20; // error
        }
    }
}