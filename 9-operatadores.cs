using System;

namespace Operadores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Tipos de operadores
                //Aritmeticos  (+, -, *, /, %, ++, --)
                int sum1 = 100 + 50;        // 150 (100 + 50)
                int sum2 = sum1 + 250;      // 400 (150 + 250)
                int sum3 = sum2 + sum2;     // 800 (400 + 400)

                //Assignment
                //Sirve para asignar valores a variables
                int x = 10;

                //Lista completa de ejemplos

                    // Operador     Ejemplo         Es igual a

                    // =	        x = 5	        x = 5	
                    // +=	        x += 3	        x = x + 3	
                    // -=	        x -= 3	        x = x - 3	
                    // *=	        x *= 3	        x = x * 3	
                    // /=	        x /= 3	        x = x / 3	
                    // %=	        x %= 3	        x = x % 3	
                    // &=	        x &= 3	        x = x & 3	
                    // |=	        x |= 3	        x = x | 3	
                    // ^=	        x ^= 3	        x = x ^ 3	
                    // >>=	        x >>= 3	        x = x >> 3	
                    // <<=	        x <<= 3	        x = x << 3

                // Comparadores
                int x = 5;
                int y = 3;
                Console.WriteLine(x > y); // returns True

                //Lista completa de ejemplos
                    // Operador     Ejemplo                  Es igual a

            //      ==	            Equal to	                x == y	
            //      !=	            Not equal	                x != y	
            //      >	            Greater than	            x > y	
            //      <	            Less than	                x < y	
            //      >=	            Greater than or equal to	x >= y	
            //      <=	            Less than or equal to	    x <= y

                //Logicos 
                //  && 	Logical and	Returns True if both statements are true	x < 5 &&  x < 10
                //  || 	Logical or	Returns True if one of the statements is true	x < 5 || x < 4
                //  !	Logical not	Reverse the result, returns False if the result is true	!(x < 5 && x < 10)

        }
    }
}