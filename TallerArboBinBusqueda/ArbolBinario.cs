using System;

namespace TallerArboBinBusqueda
{
    public class ArbolBinario
    {
        private NodoArbol raiz;

        public ArbolBinario()
        {
            this.raiz = null;            
        }

        public bool EstaVacio() {
            return (raiz is null); //si es null retornara true
        }

        public void Insertar(int llave, string dato) {
            NodoArbol nodo = null;
            NodoArbol nodoAux = null;

            nodo = new NodoArbol(llave, dato);

            if(EstaVacio()) {
                raiz = nodo;
            }
            else { //no esta vacio, al menos ya hay un nodo
                nodoAux = raiz;
                while(true) {
                    if(nodo.llave < nodoAux.llave) { //el nodo a insertarse es menor que el nodoAux, evaluo x izq
                        if(nodoAux.izq is not null) { //no es una hoja para ubicar a nodo, se avanza x izq
                            nodoAux = nodoAux.izq;
                        }
                        else { //Se llego a una hoja, si se puede insertar a nodo
                            nodoAux.izq = nodo;
                            break; //ya logre el objetivo, insertar a nodo, entonces termino el while
                        }
                    }
                    else if(nodo.llave > nodoAux.llave) { //el nodo a insertarse es menor que el nodoAux, evaluo x der
                        if(nodoAux.der is not null) { //no es una hoja para ubicar a nodo, se avanza x derecha
                            nodoAux = nodoAux.der;
                        }
                        else { //Se llego a una hoja, si se puede insertar a nodo
                            nodoAux.der = nodo;
                            break; //ya logre el objetivo, insertar a nodo, entonces termino el while
                        }
                    }
                    else { //la llave ya existe
                        throw new Exception($"el nodo con la llave {nodo.llave} ya existe!, no se permiten llaves duplicadas");
                    }
                }
            }
        }        
    
        public void RecorrerxAmplitud() {
            /*
            Siempre y cuando el arbol NO este vacio:
                1. Encole a raiz
                2. Mientras haya algun nodo encolado:
                    2.1 Desencole y en ese nodo ubique a nA(nodoAux)
                    2.2 Muestre la llave de nA
                    2.3 Encole los hijos de nA (no encole null)
            */
            //COMPLETE AQUI

        }
    }
}
