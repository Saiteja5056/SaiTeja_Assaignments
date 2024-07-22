using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    class message
    {
        string path = "E:\\sai.txt";
        public void error(Exception e)
        {
            File.WriteAllText(path, e.Message);
        }
    }
    internal class A3
    {
        
       static void Main()
        {
            int a, b;
            Console.WriteLine("enter a value");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b value");
            b=Convert.ToInt32(Console.ReadLine());
            string path = "E:\\sai.txt";
            message m= new message();
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                m.error(e);
            }
           
        }
    }
}
