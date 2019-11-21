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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DNI { get; set; }
        [Required, Column("apellido"), StringLength(45)]
        
        public string Apellido { get; set; }
        [Required, Column("nombre"), StringLength(45)]
        public string Nombre { get; set; }
        [Required,Column("email"), StringLength(45)]
        public string email { get; set; }
        [ForeignKey("nroTajeta")]
        public Tarjeta Tarjeta { get; set; }
       

        [NotMapped]
        public string NombreCompleto => $"{Apellido}, {Nombre}";

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
                Tarjeta.Saldo -= fichin.Precio;
                Console.WriteLine("Saldo disponible" + Tarjeta.Saldo);
            }

           else
                Console.WriteLine("Saldo insuficiente" + Tarjeta.Saldo);

        }

        public void Recargar(float monto)
        {
            Recarga recarga = new Recarga(this, monto);
            Tarjeta.AgregarRecarga(recarga, monto);
            Console.WriteLine("Carga realizada con esito");
          
        }

        public override string ToString()
            => $"{Nombre} - Numero de Tarjeta{Tarjeta.nroTarjeta}";
    }
}
