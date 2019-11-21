using ForeverLand;
using MenuesConsola;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaCliente.Menu
{
    public class MenuRecargar:MenuComponente
    {
        public Cliente Cliente { get; set; }
        public MenuRecargar()
        {
            var monto = prompt("Ingrese monto");
            
            RecargarTarjeta(float.Parse(monto));
        
        }

        public void RecargarTarjeta(float monto)
        {
            Cliente.Recargar(monto);
        }
    }
}
