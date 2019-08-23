using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ForeverLand
{
    [Table("Tarjeta")]
    public class Tarjeta
    {
        [Key, Column("nroTajeta")]
        public int nroTarjeta { get; set; }
        [Required, Column("saldo")]
        public float Saldo { get; set; }
        
        public List<Recarga> Recargas { get; set; }
        public Tarjeta()
        {
            Recargas = new List<Recarga>();
        }

        public void AgregarRecarga(Recarga recarga)
        {
            Recargas.Add(recarga);
        }

        public float RecargasEntre(DateTime f1, DateTime f2)
        {
            return Recargas.FindAll(h => h.entre(f1, f2)).
                Sum(h => h.Monto);
        }
    }
}
