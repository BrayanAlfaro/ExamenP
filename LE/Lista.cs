using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE
{
    public class Lista
    {
        public nodo inicio;

        public Lista()
        {
            inicio = null;
        }

        public void Insertar(string Nombre, int Edad, string Puesto)
        {
            nodo auxiliar = new nodo();
            auxiliar.Nombre = Nombre;
            auxiliar.Edad = Edad;
            auxiliar.Puesto = Puesto;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
        }
        public void mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacia");
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                Console.WriteLine("Nombre: "+ puntero.Nombre);
                Console.WriteLine("Edad: " + puntero.Edad);
                Console.WriteLine("Puesto: " + puntero.Puesto);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.WriteLine("Nombre: " + puntero.Nombre);
                    Console.WriteLine("Edad: " + puntero.Edad);
                    Console.WriteLine("Puesto: " + puntero.Puesto);
                }
            }
        }
    }
}
