using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    class Intrest
    {
        int year;
        double compoundintrest;
        double amount;
        
        public void calculateIntret()
        {
            int flag = 0;
            int i = 1;
            double amount = 1000;
            while(amount<100000)
            {
                compoundintrest = amount * 0.05;
                amount = amount + compoundintrest;
                i++;
                Console.WriteLine(i+ "year amount became "+amount);

                flag++;
            }
            Console.WriteLine("years required to reach 100000 is " + flag);
           
        }
    }
    internal class Q1
    {
        static void Main()
        {
            Intrest i = new Intrest();
            i.calculateIntret();
        }
        
    }
}

       

