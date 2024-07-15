using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment3
{
    internal class p15
    {
        static void Main()
        {

            int[] arr = new int[5];
            Console.WriteLine("enter marks");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter your choice");
            do
            {
                Console.WriteLine("1.average");
                Console.WriteLine("2.max marks");
                Console.WriteLine("3.min marks");
                Console.WriteLine("4.exit");
                Console.WriteLine("5.asscending");
                Console.WriteLine("6.descending");
                Console.WriteLine("7.total");

                int one = Convert.ToInt32(Console.ReadLine());
                switch (one)
                {
                    case 1:
                        {
                            average(arr);
                        }
                        break;
                    case 2:
                        {
                            Sort(arr);
                            Console.WriteLine("Highest marks is " + arr[4]);
                        }
                        break;
                    case 3:
                        {
                            Sort1(arr);
                            Console.WriteLine("Lowest marks is " + arr[0]);
                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case 5: { asscending(arr); } break;
                    case 6: { descending(arr); } break;
                    case 7: { Total(arr); } break;
                    default:
                        {
                            Console.WriteLine("enter valid input");
                        }
                        break;
                }

            } while (true);

        }
        static void average(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                result = result + arr[i];
            }
            Console.WriteLine(result / 5);
        }
        static Array Sort(int[] arr)
        {
            Array.Sort(arr);
            return arr;

        }
        static Array Sort1(int[] arr)
        {
            Array.Sort(arr);
            return arr;

        }
        static void Total(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                result = result + arr[i];
            }
            Console.WriteLine(result);
        }
        static Array asscending(int[] arr)
        {
            Array.Sort(arr);
            Console.Write("[ ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine(" ]");
            return arr;
        }
        static Array descending(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("[ ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine(" ]");
            return arr;

        }
    }
}

