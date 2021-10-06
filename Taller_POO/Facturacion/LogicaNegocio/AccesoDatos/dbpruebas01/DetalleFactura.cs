using System;
using System.Collections.Generic;

#nullable disable

namespace LogicaNegocio.AccesoDatos.dbpruebas01
{
    public partial class DetalleFactura
    {
        public string NumeroFactura { get; set; }
        public int Linea { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal TotalLinea { get; set; }
    }
}
