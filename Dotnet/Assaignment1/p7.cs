using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p7
    {
        static void Main()
        {
            Console.WriteLine("enter a number");
            int a=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=a;i++)
            {
                Console.WriteLine(i*i);
            }
        }
    }
}
