
using System;

namespace Recursion.Ejercicio1
{
    class SumarNumeros
    {

        public static void MainSum(string[] args)
        {
            int n1 = 1;
            int n2 = 10;
            int suma = Sum2Numbers(n1, n2, 0);
            Console.WriteLine("total is: " + suma);

        }
        public static int Sum2Numbers (int n1, int n2, int suma)
        {
            if (n1 > n2)
            {
                return suma;
            }

            suma = suma + n1;

            return Sum2Numbers(n1+1, n2, suma);
        }
        
    }
}
