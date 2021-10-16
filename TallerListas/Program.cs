using System;

namespace TallerListas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Prueba_Lista();
            //Prueba_InsertarPrimero();
            //Prueba_ObteneryRemoverPrimero();
        }

        public static void Prueba_Lista() {
            Lista lista = new Lista();
            Nodo nodo = null;

            nodo = new Nodo(15);            
            lista.Adicionar(nodo);
            nodo = new Nodo(10);
            lista.Adicionar(nodo);
            nodo = new Nodo(20);
            lista.Adicionar(nodo);
            nodo = new Nodo(6);
            lista.Adicionar(nodo);

            lista.Mostrar();
        }

        public static void Prueba_InsertarPrimero() {
            Lista lista = new Lista();
            Nodo nodo = null;

            nodo = new Nodo(15);
            lista.Adicionar(nodo);
            nodo = new Nodo(10);
            lista.InsertarPrimero(nodo);

            lista.Mostrar();
        }

        public static void Prueba_ObteneryRemoverPrimero() {
            Lista lista = new Lista();
            Nodo nodo = null;

            nodo = new Nodo(15);            
            lista.Adicionar(nodo);
            nodo = new Nodo(10);
            lista.Adicionar(nodo);

            nodo = lista.ObteneryRemoverPrimero();

            Console.WriteLine($"El dato del 1° nodo es: {nodo.dato}");
            lista.Mostrar();
        }
    }
}
