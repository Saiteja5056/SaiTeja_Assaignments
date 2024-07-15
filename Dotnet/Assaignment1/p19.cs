using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p19
    {
        static void Main()
        {
            int a = 0;
            Console.WriteLine("enter a word");
            String s=Convert.ToString(Console.ReadLine());
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[s.Length - 1])
                {
                    Console.WriteLine("it is a palindrome");
                    a++;
                }
               
            }
            if (a == 0) Console.WriteLine("not palindrome");
        }
       
    }
}
