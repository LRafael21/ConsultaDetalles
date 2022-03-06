using Microsoft.EntityFrameworkCore;
using DetalleyConsulta.Entidades;


namespace DetalleyConsulta.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<ProductosDetalle> ProductosDetalle { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

      

    }

}

