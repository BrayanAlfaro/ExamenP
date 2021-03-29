using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            string oración="anita lava la tina";
            string palindromo="";
            bool x=false;
            
            oración.Replace(" ", "");

            foreach (char a in oración)
            {
                if (!Char.IsWhiteSpace(a))
                {
                    palindromo = palindromo + a;
                }               
            }


            int b = (int)(palindromo.Length / 2);
            for (int a = 0; a <= b; a++)
            {
                if (palindromo[a] != palindromo[(palindromo.Length - a)-1])
                {
                    x = false;
                    break;
                }
                else
                {
                    x = true;
                }
            }
            if (x)
            {
                Console.WriteLine("La oración es palindromo");
            }
            else
            {
                Console.WriteLine("La oración no es palindromo");
            }
            Console.ReadKey();
        }
    }
}
