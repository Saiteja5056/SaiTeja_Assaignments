using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p8
    {
        static void Main()
        {
            int res = 1;
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                res = res * i;
            }
            Console.WriteLine(res);
        }

    }
}
