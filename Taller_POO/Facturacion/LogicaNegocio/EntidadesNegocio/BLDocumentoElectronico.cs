using System;
using System.Collections.Generic;
using LogicaNegocio.AccesoDatos.dbpruebas01;

namespace LogicaNegocio.EntidadesNegocio
{
    public class BLDocumentoElectronico
    {
        public BLDocumentoElectronico(){}

        public static string GenerarAcuse(DocumentoElectronico doc) {
            string resultado = string.Empty;
            DBPruebas01Context dbctxt = null;
            
            using(dbctxt = new DBPruebas01Context()) {
                doc.dbctxt = dbctxt;                
                if(doc.Existe()) {
                    resultado = doc.GenerarAcuse();
                }
            }

            return resultado;
        }
    }
}
