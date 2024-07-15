using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p10
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum= 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + (i * i * i);
            }

            Console.WriteLine("The sum of cubes of the first " + n + " natural numbers is: " + sum);
        }
    }
}
