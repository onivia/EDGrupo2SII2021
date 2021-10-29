using System;

namespace TallerArboBinBusqueda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Prueba_Insertar();
            Prueba_RecorrerxAmplitud();
        }

        public static void Prueba_Insertar() {
            ArbolBinario arbol = new ArbolBinario();

            arbol.Insertar(6,"seis");
            arbol.Insertar(3,"tres");
            arbol.Insertar(9,"nueve");
        }

        public static void Prueba_RecorrerxAmplitud() {
            ArbolBinario arbol = new ArbolBinario();

            arbol.Insertar(6,"seis");
            arbol.Insertar(3,"tres");
            arbol.Insertar(9,"nueve");
            arbol.Insertar(8,"ocho");
            arbol.Insertar(4,"cuatro");            
            arbol.Insertar(2,"dos");
            arbol.Insertar(7,"siete");
            arbol.Insertar(5,"cinco");
            arbol.Insertar(1,"uno");
            arbol.Insertar(10,"diez");            
            arbol.Insertar(15,"quince");

            arbol.RecorrerxAmplitud(); //Muestra los nodos del arbol, recorriendolo x amplitud
        }
    }
}
