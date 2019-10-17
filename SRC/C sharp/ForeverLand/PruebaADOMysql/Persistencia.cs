using ForeverLand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaADOMysql
{
    public  class Persistencia
   {
        static Fichin fichin { get; set; }
        static Tarjeta Tarjeta { get; set; }

        static MySqlADO Ado { get; set; }

        [ClassInitialize]
        public static void iniciarClase(TestContext context)
        {
            Ado = new MySqlADO();
            Ado.Database.EnsureDeleted();
            Ado.Database.EnsureCreated();
        }

   }
}
