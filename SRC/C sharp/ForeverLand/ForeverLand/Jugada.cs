using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ForeverLand
{
    [Table("Jugada")]
   public class Jugada: EnteCon
    {
        [Key, Column("IdJugada")]
        public int Id { get; set; }
       
        [ForeignKey("IdFichin")]
        [Required]
        public Fichin Fichin { get; set; }

        public Jugada()
        {

        }
    }
}
