using System;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class AlquilerContext : DbContext
    {
        public AlquilerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Alquiler> Alquilers { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
    }
}
