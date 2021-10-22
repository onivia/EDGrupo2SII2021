using System;

namespace TallerListas3
{
    public class Lista
    {
        private Nodo p; //apuntar al primer nodo de la lista
        private Nodo u; //apuntar al ultimo nodo de la lista
        public int tamano; //lleva registro del tamaño (de nodos) de la lista

        public Lista(){
            p = null;
            u = null;
            tamano = 0;
        }

        public bool EstaVacia() {
            //return (tamano==0)
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
            tamano+=1; //tamano++; tamano = tamano + 1;
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
                    p = null;
                    u = null;
                    tamano = 0;
                }
                else { //tiene nodos
                    nododAux = p;
                    p = nododAux.sgte;
                    nododAux.sgte = null;
                    nododAux = null;
                    tamano-=1; //tamano--;
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
                nodoCopia = new Nodo(p.dato);
                RemoverPrimero(); //reutilizo el metodo              
            }

            return nodoCopia;
        }
    
        public void Ordenar() { //Sorting
            /*
                Ordenar ascendentemente una lista, segun sus datos (tipo int)
                Ej: 9,6,4,2 => 2,4,6,9
                Aplique el metodo burbuja, tienendo en cuenta ordernar los datos ascendentemente
                sin mover nodos.
            */
            //COMPLETE AQUI
            Nodo nodoAux = null;
            int limite = tamano;
            int aux = 0;
            for (int j = 0; j < (tamano - 1); j++) //j: 0,1,2
            {
                nodoAux = p; //Al comienzo de cada corrida posiciono a nodAux en el 1er nodo
                limite -= 1; //limite--;
                for (int i = 0; i < limite; i++)
                {
                    if(nodoAux.dato > nodoAux.sgte.dato) { //Se realiza intercambio
                        aux = nodoAux.sgte.dato; //aux: 4
                        nodoAux.sgte.dato = nodoAux.dato; //6
                        nodoAux.dato = aux; //4                       
                    }
                    nodoAux = nodoAux.sgte; //Luego de comparar al nodoAux con el sgte, muevo a nodoAux al sgte nodo
                }
            }
        }
    }
}
