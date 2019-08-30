using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ForeverLand
{
    [Table("Fichin")]
    public class Fichin
    {
        [Key, Column("idFichin")]
        public byte Id { get; set; }
        [Required,Column("anio")]
        public short Anio { get; set; }
        [Required, Column("nombre")]
        public string Nombre { get; set; }
        [Required, Column("precio")]
        public float Precio { get; set; }

        public List<Jugada> Jugadas { get; set; }
        public Fichin()
        {
            Jugadas = new List<Jugada>();
        }  
        public float RecaudadoEntre(DateTime f1, DateTime f2)
        {
            return Jugadas.FindAll(h => h.entre(f1, f2)).
                Sum(h => h.Monto);
        }
    }
}
