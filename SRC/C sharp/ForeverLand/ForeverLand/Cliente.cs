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
        [Required, Column("Tarjeta")]
        public Tarjeta Tarjeta { get; set; }

        public Cliente()
        {

        }

        public void RecaudadoEntre(DateTime inicio, DateTime fin)
        {
            Tarjeta.RecargasEntre(inicio, fin);
        }
    }
}
