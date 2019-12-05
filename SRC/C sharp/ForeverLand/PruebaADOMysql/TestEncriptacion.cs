using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForeverLand;
using NETCore.Encrypt;
using ForeverLand.ADO;

namespace PruebaADOMysql
{
    [TestClass]
    public class TestEncriptacion
    {
      private MySqlADO Ado { get; set; }
        [ClassInitialize]
        public static void fixture(TestContext context)
        {
            var ado = new MySqlADO();
            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();
        }

        [TestInitialize]
       public void PersistenciaClase()
        {
            Ado = new MySqlADO();
            string passEncriptada = EncryptProvider.Sha256("asdasdasd");
            string otraPass = EncryptProvider.Sha256("asdasd");
            int dni = 1000000;
            int otroDni = 999;

            Cliente cliente = new Cliente()
            {
                DNI = dni,
                Nombre = " asdasdasd",
                Apellido = "sdfsdfsdf",
                Password = passEncriptada 
              

            };
            Ado.AltaCliente(cliente);

            Cliente cliente1 = Ado.clientePorDniPass(dni, otraPass);
            Assert.IsNull(cliente1);
            Cliente cliente2 = Ado.clientePorDniPass(otroDni, passEncriptada);
            Assert.IsNull(cliente2);
            Cliente cliente3 = Ado.clientePorDniPass(otroDni, otraPass);
            Assert.IsNull(cliente3);
            Cliente cliente4 = Ado.clientePorDniPass(dni, passEncriptada);
            Assert.IsNotNull(cliente4);
            Assert.AreEqual("asdasdasd, sdfsdfsdf", cliente4.NombreCompleto);
        }
    }
}
