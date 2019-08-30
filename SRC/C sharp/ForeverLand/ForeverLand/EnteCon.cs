using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ForeverLand
{
  public abstract class EnteCon
    {
        [ForeignKey("dni")]
        [Required]
        public Cliente Cliente { get; set; }
      
        [Required, Column("fechaHora")]
        public DateTime FechaHora { get; set; }
        [Required, Column("monto")]
        public float Monto { get; set; }
      

        public bool entre(DateTime inicio, DateTime fin)
        {
            return inicio <= FechaHora && FechaHora <= fin;
        }
        public EnteCon()
        {

        }
    }
}
