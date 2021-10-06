using System;
using LogicaNegocio.EntidadesNegocio;
using LogicaNegocio.Comun.Enumeraciones;

namespace LogicaNegocio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Empieza...");
            //Prueba_GenerarAcuse_Factura();
            //Prueba_GenerarAcuse_NotaCredito();
            //Prueba_GenerarJson_OrdenCompra();
            Console.WriteLine("...Termina");
        }

        public static void Prueba_GenerarAcuse_Factura() {
            EntidadesNegocio.Factura factura = null;
            string acuse = string.Empty;

            factura = new EntidadesNegocio.Factura();
            factura.Numero = "FAC-104";
            acuse = BLDocumentoElectronico.GenerarAcuse(factura);
            System.Console.WriteLine($"acuse, Factura No.:{factura.Numero}");
            System.Console.WriteLine($"{acuse}");
        }

        public static void Prueba_GenerarAcuse_NotaCredito() {
            EntidadesNegocio.NotaCredito notaCredito = null;
            string acuse = string.Empty;

            //CONTINUE AQUI
            
        }

        public static void Prueba_GenerarJson_OrdenCompra() {
            EntidadesNegocio.OrdenCompra ordenCompra = null;
            string jsonOC = string.Empty;
            
            ordenCompra = new EntidadesNegocio.OrdenCompra();
            //CONTINUE AQUI
                        
        }        
    }
}
