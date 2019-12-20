using MenuesConsola;
using System;
using ForeverLand;
using System.Collections.Generic;
using System.Text;


namespace ProgramaCliente.Menu
{
    public class MenuSaldo : MenuListador<Tarjeta>
    {
        public Cliente Cliente { get; set; }
        public Tarjeta Tarjeta { get; set; }

    }
}
