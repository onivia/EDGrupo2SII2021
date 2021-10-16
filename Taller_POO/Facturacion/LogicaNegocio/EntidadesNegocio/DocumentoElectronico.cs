using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LogicaNegocio.AccesoDatos.dbpruebas01;
using LogicaNegocio.Comun.Enumeraciones;

#nullable disable

namespace LogicaNegocio.EntidadesNegocio
{
    public abstract class DocumentoElectronico
    {
        public DBPruebas01Context dbctxt = null;

        public abstract void AnularDocumento();

        public void CalcularTotal() {
            throw new NotImplementedException("aun no implementado, DocumentoElectronico.calcularTotal()");
        }

        public string GenerarAcuse() {
            AccesoDatos.dbpruebas01.Factura facturaDB = null;
            AccesoDatos.dbpruebas01.NotaCredito notaCreditoDB = null;
            Factura factura = null;
            NotaCredito notaCredito = null;
            string plantillaAcuse = "<AcuseDocElectronico tipo=\"#:tipo#\"><numero>#:numero#</numero><fecha>#:fecha#</fecha><enviado>#:enviado#</enviado></AcuseDocElectronico>";
            string resultado = string.Empty;

            switch (this)
            {
                case Factura:
                    factura = (Factura)this;
                    facturaDB = dbctxt.Facturas.Where(x => x.Numero.Equals(factura.Numero)).FirstOrDefault();
                    if(facturaDB is not null) {
                        resultado = plantillaAcuse.Replace("#:tipo#","factura")
                                                .Replace("#:numero#",facturaDB.Numero)
                                                .Replace("#:fecha#",facturaDB.Fecha.ToString("dd-MM-yyyy"))
                                                .Replace("#:existe#","true");

                    }

                    return resultado;
                case NotaCredito:
                    notaCredito = (NotaCredito)this;
                    //CONTINUE AQUI
                    notaCreditoDB = dbctxt.NotaCreditos.Where(x => x.Numero.Equals(notaCredito.Numero)).FirstOrDefault();
                    if(notaCreditoDB is not null) {
                        resultado = plantillaAcuse.Replace("#:tipo#","nota credito")
                                                .Replace("#:numero#",notaCreditoDB.Numero)
                                                .Replace("#:fecha#",notaCreditoDB.Fecha.ToString("dd-MM-yyyy"))
                                                .Replace("#:existe#","true");
                    }

                    return resultado;
                default:
                    return string.Empty;
            }
        }

        public bool Existe() {
            AccesoDatos.dbpruebas01.Factura facturaDB = null;
            AccesoDatos.dbpruebas01.NotaCredito notaCreditoDB = null;
            Factura factura = null;
            NotaCredito notaCredito = null;

            switch (this)
            {
                case Factura:
                    factura = (Factura)this;
                    facturaDB = dbctxt.Facturas.Where(x => x.Numero.Equals(factura.Numero)).FirstOrDefault();

                    return (facturaDB is not null);
                case NotaCredito:
                    notaCredito = (NotaCredito)this;
                    notaCreditoDB = dbctxt.NotaCreditos.Where(x => x.Numero.Equals(notaCredito.Numero)).FirstOrDefault();

                    return (notaCredito is not null);
                default:
                    throw new Exception("DocumentoElectronico.Existe()");
            }
        }

        public static DocumentoElectronico CrearDocumentoElectronico(TipoDocumentoElectronico tipoDocElectronico) {
            switch(tipoDocElectronico)
            {
                case TipoDocumentoElectronico.FACTURA:
                    return new Factura();
                case TipoDocumentoElectronico.NOTACREDITO:
                    return new NotaCredito();
                default:
                    throw new Exception("DocumentoElectronico.CrearDocumentoElectronico()");
            }
        }
    }
}
