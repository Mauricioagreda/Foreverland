using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ForeverLand
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key, Column("dni")]
        public int DNI { get; set; }
        [Required, Column("apellido")]
        public string Apelldio { get; set; }
        [Required, Column("nombre")]
        public string Nombre { get; set; }
        [Column("email")]
        public string email { get; set; }
        [ForeignKey("nroTajeta")]
        public Tarjeta Tarjeta { get; set; }

        public Cliente()
        {

        }

        public void RecaudadoEntre(DateTime inicio, DateTime fin)
        {
            Tarjeta.RecargasEntre(inicio, fin);
        }
        public void Jugar(Fichin fichin)
        {
            if (fichin.montoSuficiente(Tarjeta.Saldo))
            {
                Jugada jugada = new Jugada(this, fichin);
                fichin.AgregarJugada(jugada);
            }
                
        }

        public void Recargar(float monto)
        {
            Recarga recarga = new Recarga(this, monto);
            Tarjeta.AgregarRecarga(recarga, monto);
          
        }
    }
}
