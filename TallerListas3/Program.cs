using System;

namespace TallerListas3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Prueba_Lista();
            //Prueba_InsertarPrimero();
            //Prueba_ObteneryRemoverPrimero();
            //Ordenamiento_Burbuja();
            //Prueba_OrdenarLista();
        }

        public static void Ordenamiento_Burbuja() { //Sorting
            //6,4,3,2 => 4,6,3,2 => 4,3,6,2 => 4,3,2,6; 1era corrida (limite=2)
            //4,3,2,6 => 3,4,2,6 => 3,2,4,6; 2da corrida (limite=1)
            //3,2,4,6 => 2,3,4,6; 3era corrida (limite=0)
            //2,3,4,6 //no se van a dar mas corridas

            int[] nums = {6,4,3,2}; //muestra
            int limite = nums.Length;
            int aux = 0;
            for (int j = 0; j < (nums.Length - 1); j++) //j: 0,1,2
            {
                limite -= 1; //limite--;
                for (int i = 0; i < limite; i++)
                {
                    if(nums[i]>nums[i+1]) { //Se realiza intercambio
                        aux = nums[i+1]; //aux: 4
                        nums[i+1] = nums[i]; //6
                        nums[i] = aux; //4                       
                    }               
                }
            }

            //Muestra el arreglo
            for (int i = 0; i < nums.Length; i++)
            {
                System.Console.WriteLine(nums[i]);                
            }
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

            lista.Mostrar(); //10,15
        }

        private static void Prueba_ObteneryRemoverPrimero() {
            Lista lista = new Lista();
            Nodo nodo = null;

            nodo = new Nodo(15);            
            lista.Adicionar(nodo);
            nodo = new Nodo(10);
            lista.Adicionar(nodo);
            nodo = new Nodo(6);
            lista.Adicionar(nodo);

            nodo = lista.ObteneryRemoverPrimero(); //15

            Console.WriteLine($"El dato del 1° nodo es: {nodo.dato}"); //15
            lista.Mostrar(); //10, 6
        }

        public static void Prueba_OrdenarLista() {
            Lista lista = new Lista();
            Nodo nodo = null;

            nodo = new Nodo(15);            
            lista.Adicionar(nodo);
            nodo = new Nodo(10);
            lista.Adicionar(nodo);
            nodo = new Nodo(6);
            lista.Adicionar(nodo);
            nodo = new Nodo(4);
            lista.Adicionar(nodo);
            nodo = new Nodo(2);
            lista.Adicionar(nodo);

            lista.Ordenar();  //Ordena Ascendentemente la lista

            lista.Mostrar(); //dberia mostrar: 2,4,6,10,15
        }
    }
}
