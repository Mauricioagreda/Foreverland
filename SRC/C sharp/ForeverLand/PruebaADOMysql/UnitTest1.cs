using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForeverLand;


namespace PruebaADOMysql
{
    [TestClass]
    public class UnitTest1
    {
        public static MySqlADO Ado { get; set; }

        [ClassInitialize]
        public static void SetUpClase(TestContext context)
        {

            Ado = new MySqlADO();
            Ado.Database.EnsureCreated();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Ado.Database.EnsureCreated();

        }
    }
}
