using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p18
    {
        static void Main()
        {
            Console.WriteLine("enter first word");
            string s = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter second word");
            string s1 = Convert.ToString(Console.ReadLine());
            if (s == s1)
            {
                Console.WriteLine("same");
            }
            else Console.WriteLine("not");


        }

    }
}
