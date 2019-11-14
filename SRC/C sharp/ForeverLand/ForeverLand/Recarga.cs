using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeverLand
{
    [Table("Recarga")]
    public  class Recarga:EnteCon
    {
        [Key, Column("IdRecarga")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("idTarjeta"), Required]
        public Tarjeta Tarjeta { get; set; }
        public  Recarga(Cliente cliente,float monto) : base(cliente,monto)
        {

        }
        public Recarga()
        {

        }
        
    }
}
