using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            TrianguloRectangulo TR = new TrianguloRectangulo(1,2,3);
            TR.a = 0;
            TR.b = 8;
            TR.c = 9;
            TR.TeoremaDePitagoras(TR.a, TR.b, TR.c);
            Console.ReadKey();
        }
    }
}
