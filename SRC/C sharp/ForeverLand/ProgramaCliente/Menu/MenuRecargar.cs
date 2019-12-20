using ForeverLand;
using MenuesConsola;

namespace ProgramaCliente.Menu
{
    public class MenuRecargar:MenuComponente
    {
        public Cliente Cliente { get; set; }
        public MenuRecargar()
        {
        
        
        }
        public override void mostrar()
        {
            base.mostrar();
            var monto = prompt("Ingrese monto");

            RecargarTarjeta(float.Parse(monto));
        }

        public void RecargarTarjeta(float monto)
        {
            Cliente.Recargar(monto);
            ClienteADO.ADO.actualizar(Cliente);
        }
    }
}
