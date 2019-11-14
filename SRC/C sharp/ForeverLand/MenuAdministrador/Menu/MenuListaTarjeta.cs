using MenuesConsola;
using System;
using System.Collections.Generic;
using System.Text;
using ForeverLand;

namespace ProgramaGerente.Menu
{
    public class MenuListaTarjeta : MenuListador<Tarjeta>
    {
        public override void imprimirElemento(Tarjeta elemento) =>  Console.WriteLine(elemento.ToString());

        public override List<Tarjeta> obtenerLista() => GerenteADO.ADO.obtenertarjetas();

      
    }
}
