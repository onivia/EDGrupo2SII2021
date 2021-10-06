using System;
using System.Collections.Generic;
using LogicaNegocio.Comun.Interfaces;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Factura : DocumentoElectronico, IDocumentoSoporte
    {
        public string Numero { get; set; }        
        public DateTime Fecha { get; set; }
        public string RazonSocial { get; set; }
        public string NumeroOrdenCompra { get; set; }

        public Factura() { }

        public override void AnularDocumento() {
            throw new NotImplementedException("aun no implementado, Factura.AnularDocumento()");
        }

        public void ObtenerFormaPago() {
            throw new NotImplementedException("aun no implementado, Factura.ObtenerFormaPago()");
        }
    }
}
