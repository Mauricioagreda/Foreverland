using ForeverLand;
using MenuesConsola;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaGerente.Menu
{
    public class MenuListaCliente : MenuListador<Cliente>
    {
        public override void imprimirElemento(Cliente c) => Console.WriteLine(c.ToString());

        public override List<Cliente> obtenerLista() => GerenteADO.ADO.obtenerclientes();
    }
}
