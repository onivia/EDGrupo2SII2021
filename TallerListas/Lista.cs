using System;

namespace TallerListas
{
    public class Lista
    {
        private Nodo p;
        private Nodo u;
        public int tamano;

        public Lista(){
            p = null;
            u = null;
            tamano = 0;
        }

        public bool EstaVacia() {
            return (p == null && u == null);
        }

        public void Adicionar(Nodo nodo) {
            /*
            Si esta vacia (‘p’ y ‘u’ apuntaran a null):
                ‘p’ y ‘u’ apuntaran a ‘nodo’
            Sino esta vacia:
                ‘u.sgte’ apuntara a ‘nodo’
                ‘u’ apuntara a ‘nodo’
            tamano+=1
            */
            if(EstaVacia()) {
                p = nodo;
                u = nodo;
            }
            else {
                u.sgte = nodo;
                u = nodo;
            }
            tamano+=1;
        }

        public void Mostrar() {
            /*
            Posicionar a ‘nodoAux’ a donde apunta ‘p’
            Mientras (no se alcance a ‘tamano’):
                Mostrar ‘nodoAux.dato’
                Posicione a ‘nodoAux’ en ‘nodoAux.sgte’
                Incremente a ‘i’
            */
            Nodo nodoAux = null;
            int i = 0;

            nodoAux = p;
            while(i < tamano) {
                Console.WriteLine(nodoAux.dato);
                nodoAux = nodoAux.sgte;
                i+=1;
            }
        }

        public void InsertarPrimero(Nodo nodo) {
            /*
            Si esta vacia:
                ‘p’ y ‘u’ apuntaran a nodo
            Sino esta vacia:
                ‘nodo.sgte’ apuntara a ‘p’
                ‘p’ apuntara a nodo
            tamano++
            */
            if(EstaVacia()) {
                p = nodo;
                u = nodo;
            }
            else {
                nodo.sgte = p;
                p = nodo;
            }
            tamano+=1;
        }

        private void RemoverPrimero() {
            /*
            NO esta vacia:
                Si tamano es 1
                    ‘p’ y ‘u’ apuntaran a null
                    Tamano es 0
                Si tamano > 1
                    ‘nA’ apuntara a ‘p’
                    ‘P’ apuntara al sgte nodo
                    ‘nA.sgte’ apuntara a null
                    ‘nA’ apuntara a null
                    tamano--
            */
            Nodo nododAux = null;

            if(!EstaVacia()) {
                if(tamano==1) {
                    //COMPLETE AQUI

                }
                else { //tiene nodos
                    //COMPLETE AQUI

                }
            }
        }

        public Nodo ObteneryRemoverPrimero() {
            /*
            1. Obtener COPIA del 1er nodo
            2. Remover 1er nodo
            3. Retornar la copia del 1er nodo
            */
            Nodo nodoCopia = null;

            if(!EstaVacia()) {
                //COMPLETE AQUI
                
            }

            return nodoCopia;
        }
    }
}
