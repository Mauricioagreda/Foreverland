using System;
using MenuesConsola;
using ProgramaGerente.Menu;

namespace Programagerente
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuAltaFichin = new menuAltaFichin();
            var menuListaFichin = new MenuListaFichin() { Nombre = "Lista Fichin" }; ;
            var menuHistorialJugada = new MenuHistorialJugada() { Nombre = "Historial Jugada" }; 
            var menuAltaTarjeta = new menuAltaTarjeta();
            var menuListaTarjeta = new MenuListaTarjeta() { Nombre = "Lista Tarjeta" };
            var menuHistorialRecarga = new MenuMostrarHistorialTarjeta() { Nombre = "Historial Recargas" };
            var menuAltaCliente = new menuAltaCliente(menuListaTarjeta);
            var menuListaCliente = new MenuListaCliente() { Nombre = "Lista Cliente" }; ;
           
 


            //MenuFichin
            var menuFichin = new MenuCompuesto() { Nombre = "Fichin" };
            menuFichin.agregarMenu(menuAltaFichin);
            menuFichin.agregarMenu(menuListaFichin);
            menuFichin.agregarMenu(menuHistorialJugada);

            //MenuFichin
            var menuTarjeta = new MenuCompuesto() { Nombre = "Tarjeta" };
            menuTarjeta.agregarMenu(menuAltaTarjeta);
            menuTarjeta.agregarMenu(menuListaTarjeta);
            menuTarjeta.agregarMenu(menuHistorialRecarga);

            //Menucliente
            var menuCliente = new MenuCompuesto() { Nombre = "Cliente" };
            menuCliente.agregarMenu(menuAltaCliente);
            menuCliente.agregarMenu(menuListaCliente);


            var menuPrincipal = new MenuCompuesto() { Nombre = "Menu" };
            menuPrincipal.agregarMenu(menuFichin);
            menuPrincipal.agregarMenu(menuTarjeta);
            menuPrincipal.agregarMenu(menuCliente);
            menuPrincipal.mostrar();
        }
    }
}
