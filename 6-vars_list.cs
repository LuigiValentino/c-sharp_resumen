using System;

namespace vars_list
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // se pueden declarar varias varables en una list separandola con comas (,)
                int x = 5, y = 6, z = 50;
                Console.WriteLine(x + y + z);
            // tambien se puede el mismo valor a multiples variables
                int x, y, z;
                x = y = z = 50;
                Console.WriteLine(x + y + z);
        }
    }
}