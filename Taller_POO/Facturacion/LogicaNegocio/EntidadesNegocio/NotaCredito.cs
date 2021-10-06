using System;
using System.Collections.Generic;

namespace LogicaNegocio.EntidadesNegocio
{
    public partial class NotaCredito : DocumentoElectronico
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroFactura { get; set; }

        public NotaCredito() {}

        public override void AnularDocumento() {
            throw new NotImplementedException("aun no implementado, NotaCredito.AnularDocumento()");
        }

        public void CalcularCUDE() {
            throw new NotImplementedException("aun no implementado, NotaCredito.CalcularCUDE()");
        }
    }
}
