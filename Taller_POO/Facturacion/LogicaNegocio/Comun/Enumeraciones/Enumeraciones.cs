using System;
using System.Collections.Generic;
using LogicaNegocio.AccesoDatos.dbpruebas01;

namespace LogicaNegocio.Comun.Enumeraciones
{
    public enum TipoDocumentoElectronico {
        FACTURA = 1,
        NOTACREDITO = 2
    }

    public enum TipoFormatoDocumento {
        JSON = 1,
        XML = 2
    }
}
