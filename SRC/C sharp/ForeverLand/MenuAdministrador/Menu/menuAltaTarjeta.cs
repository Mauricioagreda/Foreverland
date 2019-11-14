using ForeverLand;
using MenuesConsola;
using System;

namespace ProgramaGerente.Menu
{
    public  class menuAltaTarjeta : MenuComponente
    {
        private Tarjeta tarjeta { get; set; }

        public menuAltaTarjeta()
        {
            Nombre = "Alta tarjeta";
        }
        public override void mostrar()
        {
            base.mostrar();

            var saldo = float.Parse(prompt("Ingrese saldo inicial"));

            Tarjeta tarjeta = new Tarjeta()
            {
                Saldo = saldo
            };


            try
            {
                GerenteADO.ADO.AltaTarjeta(tarjeta);
                Console.WriteLine("tarjeta dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta la tarjeta: {e.Message}");
            }
            Console.ReadKey();
        }

    }
}
