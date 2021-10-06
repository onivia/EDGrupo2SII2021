using System;
using System.Collections.Generic;
using LogicaNegocio.AccesoDatos.dbpruebas01;
using LogicaNegocio.Comun.Enumeraciones;

namespace LogicaNegocio.EntidadesNegocio
{
    public class BLDocumentoSoporte
    {
        public BLDocumentoSoporte(){}

        public static string ObtenerFormato(OrdenCompra ordenCompra, TipoFormatoDocumento tipoFormatoDoc) {
            string resultado = string.Empty;
            DBPruebas01Context dbctxt = null;

            switch (tipoFormatoDoc)
            {
                case TipoFormatoDocumento.JSON:
                    using(dbctxt = new DBPruebas01Context()) {
                        ordenCompra.dbctxt = dbctxt;
                        resultado = ordenCompra.ObtenerJson();
                    }
                    break;
                
                default:
                    break;
            }

            return resultado;
        }
    }
}
