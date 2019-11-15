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
            string mail = "asdasdasd@gmail.com";
            string otroMail = "asd@gmail.com";
            Cliente cliente = new Cliente()
            {
               
                Nombre = " asdasdasd",
                Apellido = "sdfsdfsdf",
                email =mail ,
              

            };
            Ado.AltaCliente(cliente);
            Cliente cliente1 = Ado.clientePorMailPass(mail, otraPass);
            Assert.IsNull(cliente1);
            Cliente cliente2 = Ado.clientePorMailPass(otroMail, passEncriptada);
            Assert.IsNull(cliente2);
            Cliente cliente3 = Ado.clientePorMailPass(otroMail, otraPass);
            Assert.IsNull(cliente3);
            Cliente cliente4 = Ado.clientePorMailPass(mail, passEncriptada);
            Assert.IsNotNull(cliente4);
            Assert.AreEqual("asdasdasd, sdfsdfsdf", cliente4.NombreCompleto);
        }
    }
}
