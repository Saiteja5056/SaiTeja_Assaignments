using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    class students
    {
        string name;
        string fpath = "E:\\sai.txt";
        public students(string name)
        {
            this.name = name;
        }
        public void create(string fpath)
        {
            File.Create(fpath);
        }
        public void write(string name)
        {
            string content = name;
            File.AppendAllText(fpath,Environment.NewLine + content);
            
        }
        public void Read(string fpath)
        {
            File.ReadAllText(fpath);
        }

    }
    internal class A1
    {
        static void Main()
        {
            string name;
            int i = 0;

           
            while(i<5)
            {
                Console.WriteLine("enter new name");
                name = Console.ReadLine();
                students s = new students(name);
                s.write(name);
                i++;
            }

        }

    }
}
