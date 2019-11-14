using System;
using System.Collections.Generic;
using System.Text;
using ForeverLand.ADO;

namespace ProgramaGerente
{
    public static class GerenteADO
    {
       
            public static MySqlADO ADO { get; set; } =
                FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "gerente");
    }

}
