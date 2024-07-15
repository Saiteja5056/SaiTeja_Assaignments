using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p6
    {
        static void Main()
        {
            Console.WriteLine("enter degree in farenheit");
            int a = Convert.ToInt32(Console.ReadLine());
            int c;
            c = (a - 32) * (5 / 9);
            Console.WriteLine(a + "  degrees farenheit is " + c + "degree celsius");
        }

    }
}
