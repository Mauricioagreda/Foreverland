using ForeverLand;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaGerente.Menu
{
    public class MenuModificarFichin:MenuListaFichin
    {
        public Fichin Fichin { get; set; }

        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            Fichin = seleccionarElemento();
            Console.WriteLine();
            menuCambiarPrecioFichin();
        }

        private void menuCambiarPrecioFichin()
        {
            bool cambio = false;
            if (preguntaCerrada("¿Cambiar nombre?"))
            {
                Fichin.Nombre = prompt("Ingrese nombre");
                cambio = true;
            }

            if (preguntaCerrada("¿Cambiar precio ?"))
            {
                var precio = float.Parse(prompt("Precio"));
                Fichin.cambiarPrecio(precio);
                cambio = true;
            }

            if (cambio)
            {
                try
                {
                    GerenteADO.ADO.actualizar(Fichin);
                    Console.WriteLine("Producto actualizado con exito");
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
