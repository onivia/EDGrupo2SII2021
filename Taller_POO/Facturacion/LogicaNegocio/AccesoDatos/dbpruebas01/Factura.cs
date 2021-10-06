using System;
using System.Collections.Generic;

#nullable disable

namespace LogicaNegocio.AccesoDatos.dbpruebas01
{
    public partial class Factura
    {
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string RazonSocial { get; set; }
        public string NumeroOrdenCompra { get; set; }
    }
}
