using System;
using System.Collections.Generic;
using System.Text;
using ForeverLand.ADO;

namespace ProgramaCliente
{
    public static class ClienteADO
    {
       
            public static MySqlADO ADO { get; set; } =
                FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "cliente");
    }

}
