using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p9
    {
        static void Main()
        {
            int a = 0, b = 1, c;
            Console.WriteLine("enter a number");
            int d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= d; i++)
            {
                Console.WriteLine(a + " ");
                c = a + b;
                a = b;
                b = c;
            }

        }

    }
}
