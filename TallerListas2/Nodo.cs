namespace TallerListas2
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
