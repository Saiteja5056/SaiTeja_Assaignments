using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p4
    {
        static void main()
        {
            Console.WriteLine("enter a number");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(one % 2 == 0 ? "even" : "odd");

        }

    }
}
