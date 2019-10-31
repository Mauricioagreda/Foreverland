using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ForeverLand
{
    public class MySqlADO : DbContext
    {
        public DbSet<Fichin> Fichines
        { get; set; }
        public DbSet<Cliente> Clientes
        { get; set; }
        public DbSet<Recarga> Recargas
        { get; set; }
        public DbSet<Jugada> Jugadas
        { get; set; }
        public MySqlADO() :base() { }
        internal MySqlADO(DbContextOptions dbo) : base(dbo) { }

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

        public Cliente clientePorMailPass(string mail, string passwordEncrip) => Clientes.FirstOrDefault(c => c.email == mail && c.Apellido == passwordEncrip);

        

    }
}

