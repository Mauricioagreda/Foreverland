using ForeverLand;
using MenuesConsola;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaGerente.Menu
{
    public class MenuListaFichin: MenuListador<Fichin>
    {

        public override void imprimirElemento(Fichin f) => Console.WriteLine(f.ToString());

        public override List<Fichin> obtenerLista() => GerenteADO.ADO.obtenerFichines();
    }
}
