using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p14
    {
        static void Main()
        {

            int[] arr = new int[5];
            Console.WriteLine("enter values");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(arr);
            Console.WriteLine("smallest number is " + arr[0]);
        }
        static Array Sort(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

    }
}
