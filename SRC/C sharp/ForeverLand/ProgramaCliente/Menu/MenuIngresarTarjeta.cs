using ForeverLand;
using NETCore.Encrypt;
using MenuesConsola;
using System;
using System.Collections.Generic;
using System.Text;
using static System.ReadLine;


namespace ProgramaCliente.Menu
{
    public class MenuIngresarTarjeta:MenuComponente
    {
        private Cliente Cliente { get; set; }

        public MenuIngresarTarjeta() => Nombre = "Loguear";

        public MenuIngresarTarjeta(Cliente cliente)
        {
            Cliente = cliente;
        }

        public override void mostrar()
        {
            base.mostrar();
            var DNI = Convert.ToInt32(prompt("Ingrese numero de DNI"));
            var Contraseña = ReadPassword("Ingrese su contraseña");
            Contraseña = EncryptProvider.Sha256(Contraseña);
            var Cliente = ClienteADO.ADO.usuarioPorDNI(DNI,Contraseña);

            if (Cliente is null)
                Console.WriteLine("El DNI es incorrecto o la contraseña son incorrectos");
            else
            {
                var menuJugar = new MenuJugar() {Nombre = "Jugar" };
                menuJugar.Cliente = Cliente;
                var menuRecargar = new MenuRecargar() { Nombre = "Recargar" };
                menuRecargar.Cliente = Cliente;
                var MenuCliente = new MenuCompuesto() { Nombre = "Menu de opciones" };
                MenuCliente.agregarMenu(menuJugar);
                MenuCliente.agregarMenu(menuRecargar);
                MenuCliente.mostrar();
            }
            Console.ReadKey();
        }
    }

}
