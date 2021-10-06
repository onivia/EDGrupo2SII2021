using System;
using System.Collections.Generic;
using System.Linq;
using LogicaNegocio.AccesoDatos.dbpruebas01;
using LogicaNegocio.Comun.Interfaces;

namespace LogicaNegocio.EntidadesNegocio
{
    public partial class OrdenCompra: IDocumentoSoporte
    {
        public DBPruebas01Context dbctxt = null;

        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroRequisicion { get; set; }

        public OrdenCompra() {}

        public void ObtenerFormaPago()
        {
            throw new NotImplementedException("aun no implementado, OrdenCompra.ObtenerFormaPago()");
        }

        public string ObtenerJson() {
            AccesoDatos.dbpruebas01.OrdenCompra ordenCompraDB = null;
            string plantillaFormato = "{\"NumeroOC\":\"#:NumeroOC#\",\"Fecha\":\"#:Fecha#\",\"NumeroRequisicion\":\"#:NumeroRequisicion#\"}";
            string resultado = string.Empty;            
            
            //ADICIONE AQUI, la linea que falta
            
            if(ordenCompraDB is not null) {
                resultado = plantillaFormato.Replace("#:NumeroOC#",ordenCompraDB.Numero)
                                            .Replace("#:Fecha#",ordenCompraDB.Fecha.ToString("dd-MM-yyyy"))
                                            .Replace("#:NumeroRequisicion#",ordenCompraDB.NumeroRequisicion);
            }

            return resultado;
        }
    }
}
