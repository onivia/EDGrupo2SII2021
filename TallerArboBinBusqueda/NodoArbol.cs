using System;

namespace TallerArboBinBusqueda
{
    public class NodoArbol
    {
        public NodoArbol izq;
        public NodoArbol der;
        public int llave;
        public string dato;

        public NodoArbol(int llave, string dato)
        {
            this.llave = llave;
            this.dato = dato;
            this.izq = null;
            this.der = null;            
        }
    }
}
