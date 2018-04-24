using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Nodo<T>
    {
        Nodo<T> hijoIzq;
        Nodo<T> hijoDer;
        Nodo<T> contenido;

        public Nodo(Nodo<T> miContenido, Nodo<T> miHijoIzq, Nodo<T> miHijoDer)
        {
              contenido = miContenido;
              hijoIzq = miHijoIzq;
              hijoDer = miHijoDer;
        }

        public Nodo<T> GetContenido()
        {
            return contenido;
        }
        public Nodo<T> GetHijoIzq()
        {
            return hijoIzq;
        }
        public Nodo<T> GetHijoDer()
        {
            return hijoDer;
        }
    }
}
