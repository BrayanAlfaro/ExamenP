using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    public class Triangulo
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public Triangulo(double a, double b, double c)
        {

        }

        public void TeoremaDePitagoras(double a, double b, double c)
        {
            if (c == 0)
            {
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Console.WriteLine("El valor del lado c es: "+c);               
            }
            else if (a == 0)
            {
                if (b > c)
                {
                    Console.WriteLine("El lado b no puede ser mayor que c");
                }
                else
                {
                    a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
                    Console.WriteLine("El valor del lado a es: " + a);
                }                
            }
            else if(b==0)
            {
                if (a > c)
                {
                    Console.WriteLine("El lado a no puede ser mayor que c");
                }
                else
                {
                    b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
                    Console.WriteLine("El valor del lado b es: " + b);
                }
                
            }
            else
            {
                Console.WriteLine("Todos los lados tienen un valor");
            }
        }
    }
    public class TrianguloRectangulo : Triangulo
    {
        public TrianguloRectangulo(double a, double b, double c)
            : base(a, b, c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
    
}
