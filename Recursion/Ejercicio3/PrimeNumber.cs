
using System;

namespace Recursion.Ejercicio3
{
    class PrimeNumber
    {
        public static void MainPrime(string[] args)
        {
            int num = 7;
            bool primo = Prime(num, num-1);
            if (primo == true)
            {
                Console.WriteLine("The number " + num + " is a prime number");
            }
            else
            {
                Console.WriteLine("The number " + num + " is not a prime number");
            }
        }


        public static bool Prime (int num, int cont)
        {
            if (cont == 1)
            {
                return true;
            }
            else
            {
                if (num % cont == 0)
                {
                    return false;
                }
                else
                {
                    return Prime(num, cont - 1);
                }
            }


        }
    }
}
