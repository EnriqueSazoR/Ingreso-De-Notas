using Microsoft.EntityFrameworkCore;


namespace NotasApp.Models
{
    public class RegistroNota : DbContext
    {
        public DbSet<Alumno> Notas { get; set; }

        public RegistroNota(DbContextOptions<RegistroNota> options) : base (options)
        {
            
        }
    }
}