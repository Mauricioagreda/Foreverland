using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using ForeverLand;

namespace ProgramaGerente.Menu
{
   public class MenuListadoJugada : MenuListador<Jugada>
   {
        public Fichin Fichin { get; set; }
        public override void imprimirElemento(Jugada j) => Console.WriteLine($"{j.FechaHora.ToShortDateString()} - {j.Monto}");

        
        public override List<Jugada> obtenerLista()
        {
            return GerenteADO.ADO.historialDeF(Fichin);


        }
    }
}
