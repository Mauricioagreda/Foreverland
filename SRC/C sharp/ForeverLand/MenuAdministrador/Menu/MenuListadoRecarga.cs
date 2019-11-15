using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using ForeverLand;

namespace ProgramaGerente.Menu
{
    public class MenuListadoRecarga : MenuListador<Recarga>
    {
        public Tarjeta Tarjeta { get; set; }
        public override void imprimirElemento(Recarga r) => Console.WriteLine($"{r.FechaHora.ToShortDateString()} - {r.Monto}");

        public override List<Recarga> obtenerLista()
        {
            return GerenteADO.ADO.historialDe(Tarjeta);


        }
    }
}
