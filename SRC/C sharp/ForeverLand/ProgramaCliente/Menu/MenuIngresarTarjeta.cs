using ForeverLand;
using MenuesConsola;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaCliente.Menu
{
    public class MenuIngresarTarjeta:MenuComponente
    {
        private Cliente Cliente { get; set; }

        public MenuIngresarTarjeta() => Nombre = "Logear";

        public override void mostrar()
        {
            base.mostrar();
            var DNI = prompt("Ingrese numero de DNI");
            var Cliente = ClienteADO.ADO.usuarioPorDNI(int.Parse(DNI));

            if (Cliente is null)
                Console.WriteLine("El DNI es incorrecto");
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
        }
    }

}
