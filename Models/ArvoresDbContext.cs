using Microsoft.EntityFrameworkCore;
    

namespace ApiPomar.Models
{
        public class ArvoresDbContext : DbContext 
        {

            public ArvoresDbContext (DbContextOptions<ArvoresDbContext> options) : base (options) { }

            public DbSet<Arvores> Arvores { get; set; }

        }
   
    }
    