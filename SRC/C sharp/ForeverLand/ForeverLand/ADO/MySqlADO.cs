using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ForeverLand.ADO
{
    public class MySqlADO : DbContext
    {
        public DbSet<Fichin> Fichines
        { get; set; }
        public DbSet<Tarjeta> Tarjetas
        { get; set; }
        public DbSet<Cliente> Clientes
        { get; set; }
        public DbSet<Recarga> Recargas
        { get; set; }
        public DbSet<Jugada> Jugadas
        { get; set; }
       
       
        public MySqlADO() :base() { }
        internal MySqlADO(DbContextOptions dbo) : base(dbo) { }

        public Cliente usuarioPorDNI(int dni)
            => Clientes.
                Where(c => c.DNI == dni).
                Include(c => c.Tarjeta).
                ThenInclude(t => t.Recargas).
                ToList().
                FirstOrDefault();

        public List<Tarjeta> obtenertarjetas() => Tarjetas.ToList();

        public List<Cliente> obtenerclientes() => Clientes
                    .Include(c => c.Tarjeta)
                    .ToList();

        public List<Fichin> obtenerFichines() => Fichines
            .Include(f => f.Jugadas)
            .ToList();
            
           

        public List<Recarga> historialDe(Tarjeta tarjeta) => Recargas
                    .Where(historial => historial.Tarjeta == tarjeta)
                    .ToList();

        public List<Jugada> historialDeF(Fichin fichin) => Jugadas
                    .Where(historial => historial.Fichin == fichin)
                    .ToList();




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

        public void AltaTarjeta(Tarjeta tarjeta)
        {
            Tarjetas.Add(tarjeta);
            SaveChanges();
        }

        

        public void actualizar(Fichin fichin)
        {
            this.Attach<Fichin>(fichin);
            SaveChanges();
        }

        public void actualizar(Cliente cliente)
        {
            this.Attach<Cliente>(cliente);
            SaveChanges();
        }

        public Cliente clientePorDniPass(int dni, string passEncriptada)
            => Clientes.FirstOrDefault(c => c.DNI == dni && c.Password == passEncriptada);


    }
}

