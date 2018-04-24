using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio del arbol binario!");

            Nodo<string> nodo1 = new Nodo<string> (Nodo<string> "contenido", "Ismael", "Daniel");
            Console.WriteLine("{0}",nodo1.GetContenido());

            Console.ReadKey();
        }
    }
}
