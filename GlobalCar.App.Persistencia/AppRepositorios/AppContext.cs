using Microsoft.EntityFrameworkCore;
using GlobalCar.App.Dominio;

namespace GlobalCar.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Especialista> Especialistas {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}
        public DbSet<Servicio> Servicios {get;set;}
        public DbSet<ServicioEspecialista> ServicioEspecialistas {get;set;}
        public DbSet<Historial> Historiales {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GlobalCarData");
            }
        }
    }
}
