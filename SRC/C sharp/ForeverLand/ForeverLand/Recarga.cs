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
        public int Id { get; set; }

       
        public  Recarga(Cliente cliente,float monto) : base(cliente,monto)
        {

        }
        public Recarga()
        {

        }
        
    }
}
