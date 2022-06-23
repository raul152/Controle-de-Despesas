using ControleDespesas.Models.Despesas;
using Microsoft.EntityFrameworkCore;

namespace ControleDespesas.Infraestrutura.BancoDeDados
{
    public class DespesasContext : DbContext
    {
        public DbSet<Despesa> Despesas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Integrated Security=SSPI;Initial Catalog=DespesasDB;Persist Security Info=False;Data Source=DESKTOP-EK7D4MU");
    }
}
