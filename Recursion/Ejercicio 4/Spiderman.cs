using System;

namespace Recursion.Ejercicio_4
{
    class Spiderman
    {
        public static void Main(string[] args)
        {
            int num = 3;
            int total = PossibleSteps(num,1);
            Console.WriteLine("total is: " + total);
        }
        public static int PossibleSteps(int num, int i)
        {
            if (num >= 2)
            {
                return PossibleSteps(num - 1, i) + PossibleSteps(num - 2,i);
            }
            else if (num == i)
            {
                    return (num);
               
            }
            else
            {
                return i;
            }
        }
    }
}
