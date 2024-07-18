using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    internal class Q2
    {
       
        static void Main()
        {
            
            
                int[,] a = new int[3, 3];
                a[0, 0] = 1;
                a[0, 1] = 2;

                a[0, 2] = 3;
                a[1, 0] = 4;
                a[1, 1] = 5;
                a[1, 2] = 6;
                a[2, 0] = 7;
                a[2, 1] = 8;
                a[2, 2] = 9;                
                    for (int i = 0; i < 3; i++)
                    {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write(" " + a[i, j] + " ");
                }                                          

                    }

                

                
            
            

        }
    }
}
