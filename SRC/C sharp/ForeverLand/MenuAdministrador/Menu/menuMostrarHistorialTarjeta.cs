using ForeverLand;
using System;

namespace ProgramaGerente.Menu
{
    public class MenuMostrarHistorialTarjeta : MenuListaTarjeta
    {
        public Tarjeta Tarjeta { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            Tarjeta = seleccionarElemento();
            Console.WriteLine();
            var menuHistorial = new MenuListadoRecarga();
            menuHistorial.Tarjeta = Tarjeta;
            menuHistorial.mostrar();
        }
    }
}
