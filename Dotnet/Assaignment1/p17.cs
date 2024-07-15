using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p17
    {
        static void Main()
        {
            Console.WriteLine("enter a word");
            string s = Convert.ToString(Console.ReadLine());
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }


        }

    }
}
