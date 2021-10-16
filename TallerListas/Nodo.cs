using System;

namespace TallerListas
{
    public class Nodo
    {
        public int dato;
        public Nodo sgte;

        public Nodo(int dato){
            this.dato = dato;
            this.sgte = null;
        }
    }
}
