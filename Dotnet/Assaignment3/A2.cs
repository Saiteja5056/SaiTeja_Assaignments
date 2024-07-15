using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment5
{
    class con
    {
        string ttype;
        string capacity;
        string dimensions;
        public con(string ttype, string capacity, string dimensions)
        {
            this.ttype = ttype;
            this.capacity = capacity;
            this.dimensions = dimensions;
            showdata();
        }      
        public void showdata()
        {
            if(ttype== "f")
            {
                Console.WriteLine("you chossed the flat");
                Console.WriteLine("your flat is " + capacity);
                Console.WriteLine("your flat is in 2nd floor");
            }
            else if(ttype=="v")
            {
                Console.WriteLine("you chossed the villa");
                Console.WriteLine("your villa dimensions are is " + dimensions);
                Console.WriteLine("it will be completed in 3 months");
            }
        }
    }

    internal class A2
    {
        static void Main()
        {
            Console.WriteLine("enter your choice for flat f and for villa v");
            string ttype=Console.ReadLine();
            Console.WriteLine("enter which one u want 2BHK/3BHK/4BHK");
            string capacity = Console.ReadLine();

            Console.WriteLine("enter dimensions of villa like 20X30X40");
            string dimensions= Console.ReadLine();
            con c = new con(ttype, capacity, dimensions);
        }
    }
}
