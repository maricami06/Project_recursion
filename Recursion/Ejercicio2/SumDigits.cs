using System;

namespace Recursion.Ejercicio2
{
    class SumDigits
    {

        public static void MainSumardig(string[] args)
        {
            int num = 125;
            int total = SumarDig(num);
            Console.WriteLine("total is: " + total);

        }

        public static int SumarDig(int n)
        {
            if (n <= 9)
            {
                return n;
            }

            return SumarDig (n / 10) + (n % 10);

        }
    }
}
