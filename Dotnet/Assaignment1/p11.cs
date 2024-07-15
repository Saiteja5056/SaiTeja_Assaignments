using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p11
    {
        static void Main()
        {
            {

                Console.WriteLine("enter  number");
                int a = Convert.ToInt32(Console.ReadLine());


                for (int i = 1; i <= 20; i++)
                {

                    Console.WriteLine($"{a}*{i}={a * i}");

                }


            }

        }
    }
}
