using ForeverLand;
using MenuesConsola;
using System;
using System.Collections.Generic;
using System.Text;
using ForeverLand.ADO;

namespace ProgramaCliente.Menu
{
    public class MenuListaFichin: MenuListador<Fichin>
    {

        public override void imprimirElemento(Fichin f) => Console.WriteLine(f.Nombre);

        public override List<Fichin> obtenerLista() => ClienteADO.ADO.obtenerFichines();
       
    }
}
