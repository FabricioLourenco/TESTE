using GreenTech.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GreenTech.Repository.Context
{
    public class GreenTechContext : DbContext
    {
        public GreenTechContext(DbContextOptions<GreenTechContext> options) : base(options)
        {

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Dados> Dados { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<CadastroResiduo> CadastroResiduo { get; set; }
        public DbSet<Ranking> Ranking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
