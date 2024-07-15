using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p3
    {
        static void main()
        {
            Console.WriteLine("enter 2 numbers");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            for (int i = one + 1; i < two - 1; i++)
                Console.WriteLine(i);

        }

    }
}
