using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForeverLand;
using NETCore.Encrypt;


namespace PruebaADOMysql
{
    [TestClass]
    public class TestCreacionBD
    {
        public static MySqlADO Ado { get; set; }

        [ClassInitialize]

        public static void SetUpClase(TestContext context)
        {

            Ado = new MySqlADO();
            Ado.Database.EnsureDeleted();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Ado.Database.EnsureCreated();

        }
        
    }
}
