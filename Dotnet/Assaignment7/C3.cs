using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Tasks
{
    internal class Three
    {
        static void Main()
        {
            SortedDictionary<int, string> emp = new SortedDictionary<int, string>();

            Console.WriteLine("Enter employee details (code name). enter 'done' to finish:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done") break;

                string[] parts = input.Split(' ');
                int code = int.Parse(parts[0]);
                string name = parts[1];

                emp[code] = name;
            }

            Console.WriteLine("Details in sorted order:");
            foreach (var a in emp)
            {
                Console.WriteLine($"Code: {a.Key}, Name: {a.Value}");
            }
        }
    }
}
