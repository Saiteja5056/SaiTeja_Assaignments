using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p5
    {
        static void main()
        {
            int e = 0;
            int f = 0;
            Console.WriteLine("enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter values");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    e++;
                }
                else f++;
            }
            Console.WriteLine("user given " + e + " even numbers");
            Console.WriteLine("user given " + f + " even numbers");



        }

    }
}
