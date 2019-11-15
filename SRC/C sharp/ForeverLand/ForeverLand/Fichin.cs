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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        [Required,Column("anio")]
        public short Anio { get; set; }
        [Required, Column("nombre"), StringLength(45)]
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
            return Jugadas.FindAll(r => r.entre(f1, f2)).
                Sum(r => r.Monto);
        }
        public void AgregarJugada(Jugada jugada)
        {
            Jugadas.Add(jugada);
        }

        public bool montoSuficiente(float monto) => monto <= this.Precio;


        public void cambiarPrecio(float precio)
        {
            Precio = precio;                   
        }

        public override string ToString()
            => $"{Nombre} - Precio{Precio} - ";
    }
}
