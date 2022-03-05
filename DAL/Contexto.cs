using Microsoft.EntityFrameworkCore;
using DetalleyConsulta.Entidades;
using DetalleyConsulta.Detalle;

namespace DetalleyConsulta.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

      

    }

}

