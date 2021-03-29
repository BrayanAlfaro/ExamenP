using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    public class Lista
    {
        public nodo inicio;

        public Lista()
        {
            inicio = null;
        }

        public void Insertar(nodo datos)
        {
            nodo auxiliar = new nodo();
            auxiliar.Nombre = datos.Nombre;
            auxiliar.Edad = datos.Edad;
            auxiliar.Puesto = datos.Puesto;
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
                Console.WriteLine("Lista vacia\n");
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                Console.WriteLine("Nombre: " + puntero.Nombre);
                Console.WriteLine("Edad: " + puntero.Edad);
                Console.WriteLine("Puesto: " + puntero.Puesto+"\n");
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.WriteLine("Nombre: " + puntero.Nombre);
                    Console.WriteLine("Edad: " + puntero.Edad);
                    Console.WriteLine("Puesto: " + puntero.Puesto+"\n");
                }               
            }
        }

        public void BuscarNombre(string Nombre)
        {
            nodo puntero;
            bool a = false;
            puntero = inicio;
            while (puntero.siguiente != null)
            {
                if (puntero.Nombre == Nombre)
                {
                    Console.WriteLine("Nombre: " + puntero.Nombre);
                    Console.WriteLine("Edad: " + puntero.Edad);
                    Console.WriteLine("Puesto: " + puntero.Puesto + "\n");
                    a=true;
                    break;
                }
                puntero = puntero.siguiente;
            }
            if (puntero.Nombre == Nombre)
            {
                Console.WriteLine("Nombre: " + puntero.Nombre);
                Console.WriteLine("Edad: " + puntero.Edad);
                Console.WriteLine("Puesto: " + puntero.Puesto + "\n");
                a = true;               
            }
            if (!a)
            {
                Console.WriteLine("No se encontro el registro");
            }
        }

        public void EliminarTodo()
        {            
            inicio = null;
        }

        public void LeerArchivo()
        {   
            string textFile = @"C:\Examen\Lista.txt";
            string linea;
            string[] Datos;
            var documentConverted = new FileStream(textFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //Stream documentConverted = file.InputStream;
            if (!string.IsNullOrEmpty(textFile))
            {
                using (StreamReader sr = new StreamReader(documentConverted))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        nodo datos = new nodo();
                        Datos = linea.Split('|');
                        datos.Nombre = Datos[0];
                        datos.Edad = int.Parse(Datos[1]);
                        datos.Puesto = Datos[2];
                        Insertar(datos);
                    }
                }
            }
        }

        
        public void DescargarArchivo()
        {
            var path = @"C:\Users\ALIEN 14\Documents\Brayan Alfaro Peña\DatosLista.txt";
            nodo puntero;
            puntero = inicio;
            List<string> listtext = new List<string>();
            while (puntero.siguiente != null)
            {
                string text = puntero.Nombre+"|"+puntero.Edad+"|"+puntero.Puesto;
                listtext.Add(text);
                puntero = puntero.siguiente;
            }
            string tex = puntero.Nombre + "|" + puntero.Edad + "|" + puntero.Puesto;
            listtext.Add(tex);
            File.WriteAllLines(path, listtext);

            //using (StreamWriter bw = new StreamWriter(File.Create("DatosLista")))
            //{
            //    nodo puntero;
            //    puntero = inicio;
            //    while (puntero.siguiente != null)
            //    {
            //        string randomstring = puntero.Nombre + "|" + puntero.Edad + "|" + puntero.Puesto;
            //        bw.Write(randomstring);
            //        puntero = puntero.siguiente;

            //    }
            //    bw.Close();
            //}
        }

    }
}
