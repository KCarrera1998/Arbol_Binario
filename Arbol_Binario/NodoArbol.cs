using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    internal class NodoArbol
    {
        public NodoArbol? SubArbolIzquierdo { get; set; }
        public NodoArbol? SubArbolDerecho { get; set; }
        public object? Informacion { get; set; }
        public NodoArbol()
        {
            SubArbolIzquierdo = null;
            SubArbolDerecho = null;
            Informacion = null;
        }

        public NodoArbol(object informacion)
        {
            SubArbolIzquierdo = null;
            SubArbolDerecho = null;
            Informacion = informacion;
        }

        public NodoArbol(NodoArbol subArbolIzquierdo, NodoArbol subArbolDerecho, object informacion)
        {
            SubArbolIzquierdo = subArbolIzquierdo;
            SubArbolDerecho = subArbolDerecho;
            Informacion = informacion;
        }

        public override string ToString()
        {
            return $"/{Informacion}\\";
        }
    }
}
