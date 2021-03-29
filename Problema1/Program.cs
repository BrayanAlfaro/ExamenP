using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0,a=0;
            for (int i = 1; i <= 99; i++)
            {
                if ((i % 2) != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("(for)La suma es: "+ sum);
            sum = 0;
            do
            {
                if ((a % 2) != 0)
                {
                    sum = sum + a;
                }
                a++;
            } while (a <= 99);
            Console.WriteLine("(Do while)La suma es: " + sum);
            sum = 0;
            a = 1;
            while (a <= 99)
            {
                if ((a % 2) != 0)
                {
                    sum = sum + a;
                }
                a++;
            }
            Console.WriteLine("(while)La suma es: " + sum);
            Console.ReadKey();
        }
    }
}
