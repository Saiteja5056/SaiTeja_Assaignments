using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p13
    {
        static void Main()
        {

            int[] arr = new int[3];
            Console.WriteLine("enter values");
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(arr);
            Console.WriteLine("largest number is " + arr[2]);
        }
        static Array Sort(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

    }
}
