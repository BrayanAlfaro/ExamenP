using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            nodo datos = new nodo();
            datos.Nombre = "Brayan";
            datos.Edad = 22;
            datos.Puesto = "Desarrollador";
            lista.Insertar(datos);
            datos.Nombre = "Sandra";
            datos.Edad = 21;
            datos.Puesto = "Administrador";
            lista.Insertar(datos);
            datos.Nombre = "Christopher";
            datos.Edad = 21;
            datos.Puesto = "Desarrollador";
            lista.Insertar(datos);
            datos.Nombre = "Claudia";
            datos.Edad = 28;
            datos.Puesto = "Lider";
            lista.Insertar(datos);
            lista.mostrar();
            lista.BuscarNombre("Claudia");
            lista.EliminarTodo();
            lista.mostrar();
            lista.LeerArchivo();
            lista.mostrar();
            lista.DescargarArchivo();
            Console.ReadKey();
        }
    }
}
