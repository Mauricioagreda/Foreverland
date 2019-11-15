using ForeverLand;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaGerente.Menu
{
    public class MenuHistorialJugada:MenuListaFichin
    {
        public Fichin Fichin { get; set; }
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine(Nombre);

            Fichin = seleccionarElemento();
            Console.WriteLine();
            var menuHistorial = new MenuListadoJugada();
            menuHistorial.Fichin = Fichin;
            menuHistorial.mostrar();
        }
    }
}
