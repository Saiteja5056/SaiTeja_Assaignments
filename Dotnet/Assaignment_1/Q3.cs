using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assaignment_1
{
    class Car
    {
        public static void Create(string path)
        {
            File.Create(path); 
        }
        public static void Write(String path)
        {
            Console.WriteLine("Enter model name :");

            string model = Console.ReadLine();
            Console.WriteLine("Enter year of the model :");
            string year = Console.ReadLine();
            File.AppendAllText(path, model);
            File.AppendAllText(path, year);

        }

    }
    internal class Q3
    {
        static void Main(string[] args)
        {
            try
            {
                Car.Create("D:\\Dotnet\\Dotnetc#\\siteja_assaignment\\sample.txt");
               


            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

