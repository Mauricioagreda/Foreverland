using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ForeverLand
{
    public class MySqlADO: DbContext
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
        public void AltaCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
            SaveChanges();
        }
        public void AltaRecargas(Recarga recarga)
        {
            Recargas.Add(recarga);
            SaveChanges();
        }
        public void AltaJugada(Jugada jugada)
        {
            Jugadas.Add(jugada);
            SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseMySQL("server=localhost;database=ForeverLand;user=root;password=root");
        }

    }
}
