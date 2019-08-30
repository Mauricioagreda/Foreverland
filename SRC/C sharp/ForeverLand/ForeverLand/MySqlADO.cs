using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ForeverLand
{
    class MySqlADO: DbContext
    {
        public DbSet<Fichin>Fichines
        {get; set; }
        public DbSet<Cliente>Clientes
        {get; set; }
        public DbSet<Recarga>Recargas
        {get; set; }
        public DbSet<Jugada>Jugadas
        {get; set; }

        public void AltaFichin(Fichin fichin)
        {
            Fichines.Add(fichin);
            SaveChanges();
        }
    }
}
