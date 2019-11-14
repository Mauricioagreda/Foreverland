using ForeverLand;
using MenuesConsola;
using System;

namespace ProgramaGerente.Menu
{
    public class menuAltaFichin: MenuComponente
   {
        private Fichin fichin { get; set; }

        public menuAltaFichin()
        {
            Nombre = "Alta fichin";

        }
        public override void mostrar()
        {
            base.mostrar();

            var nombre = prompt("Ingrese nombre del fichin");
            var precio = float.Parse(prompt("Ingrese precio"));
            //

            fichin = new Fichin()
            {
                Nombre = nombre,
                Precio = precio
            };

            try
            {
                GerenteADO.ADO.AltaFichin(fichin);
                Console.WriteLine("fichin dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta el Fichin: {e.Message}");
            }
            Console.ReadKey();

        }
    }
}


