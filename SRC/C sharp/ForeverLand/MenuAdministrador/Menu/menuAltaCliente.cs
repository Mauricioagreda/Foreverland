using MenuesConsola;
using ForeverLand;
using System;
using static System.ReadLine;

namespace ProgramaGerente.Menu
{
    public class menuAltaCliente:MenuComponente
    {
        private Cliente cliente { get; set; }
       private MenuListaTarjeta MenuListaTarjetas { get; set; }
        public menuAltaCliente(MenuListaTarjeta menuListaTarjeta)
        {
            Nombre = "Alta cliente";
            MenuListaTarjetas = menuListaTarjeta;
        }
        public override void mostrar()
        {
            base.mostrar();

            var nombre = prompt("Ingrese nombre del Cliente");
            var apellido = prompt("Ingrese apellido del Cliente");
            var mail = prompt("Ingrese mail del Cliente");
            var tarjeta = MenuListaTarjetas.seleccionarElemento();
            var dni = prompt("Ingrese DNI");
            var pass = ReadPassword("Ingrese contraseña: ");



            cliente = new Cliente()
            {
                Nombre = nombre,
                Apellido = apellido,
                email = mail,
                Tarjeta = tarjeta,
                Password = pass,


                DNI = int.Parse(dni)
                
            };
        
            try
            {
                GerenteADO.ADO.AltaCliente(cliente);
                Console.WriteLine("Cliente dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta el Cliente: {e.Message} - {e.InnerException.Message}");
            }
            Console.ReadKey();

        }
    }
}
