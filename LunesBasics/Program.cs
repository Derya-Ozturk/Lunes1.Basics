using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunesBasics
{
    class Program
    {
        //1.2
        public static void AscOrder()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        //1.3
        public static void DescOrder()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        //1.4 for-loop
        public static int Sum(int n)
        {
            int sum = 0;
            Console.Write("The sum of all numbers from 1 to " + n + ": ");
            
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;           
        }

        //1.5 while-loop
        public static int Sum_A(int n)
        {
            int num = 0;
            int sum = 0;
            Console.Write("The sum of all numbers from 1 to " + n + ": ");
            while (num == 0)
            {
                sum = (n * (n + 1)) / 2;
                break;
            }
            return sum;
        }

        //1.6 LINQ
        public static int Sum_B(int n)
        {
            Console.Write("The sum of all numbers from 1 to " + n + ": ");
            var sum = Enumerable.Range(1, n).Sum();
            return sum;
        }


        static void Main(string[] args)
        {
            //1.2
            //AscOrder();

            //1.3
            //DescOrder();

            //1.4
            //Console.WriteLine(Sum(10));
            //Console.ReadKey();

            //1.5-A
            //Console.WriteLine(Sum_A(9));
            //Console.ReadKey();

            //1.5-B
            Console.WriteLine(Sum_B(8));
            Console.ReadKey();
        }
    }

}

