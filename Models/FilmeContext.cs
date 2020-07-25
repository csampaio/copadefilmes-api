using Microsoft.EntityFrameworkCore;
using copadefilmes_api.Models;

namespace copadefilmes_api.Models
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options)
            : base(options)
        {
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
