using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PerfectNumber
    {
        public static void FindThePerfectNumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find the Perfect Number Within the Range");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Input the statring range or number");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Ending range of number ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Perfect number in the given range is :- ");

            for ( n = mn; n <= mx; n++ )
            {
                i = 1;
                sum = 0;

                while(i<n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write(" {0} ", n);
            }
        }
    }
}
