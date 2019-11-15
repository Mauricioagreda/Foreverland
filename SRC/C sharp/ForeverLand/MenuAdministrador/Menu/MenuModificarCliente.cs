using ForeverLand;
using MenuesConsola;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaGerente.Menu
{
    public class MenuModificarCliente: MenuListaCliente
    {
        public Cliente Cliente { get; set; }

        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            Cliente = seleccionarElemento();
            Console.WriteLine();
            menuModificarCliente();
        }

        private void menuModificarCliente()
        {
            bool cambio = false;
            if (preguntaCerrada("¿Cambiar tarjeta?"))
            {
                //Cliente.Tarjeta = prompt("Ingrese nombre");
                cambio = true;
            }

            

            if (cambio)
            {
                try
                {
                    GerenteADO.ADO.actualizar(Cliente);
                    Console.WriteLine("Cliente actualizado con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
                Console.ReadKey();
            }
        }
    }
}
