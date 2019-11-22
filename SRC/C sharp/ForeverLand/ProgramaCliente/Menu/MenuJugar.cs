using ForeverLand;
using MenuesConsola;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaCliente.Menu
{
    public class MenuJugar : MenuListaFichin
    {
       public Cliente Cliente { get; set; }
       private Fichin fichin { get; set; }
      

       

        public override void mostrar()
        {
           
            Console.Clear();
            Console.WriteLine(Nombre);

            fichin = seleccionarElemento();

            JugarFichin(fichin);
          
        }


        public void JugarFichin(Fichin fichin)
        {
            Cliente.Jugar(fichin);

            ClienteADO.ADO.actualizar(Cliente);
            
        }

    }
}
