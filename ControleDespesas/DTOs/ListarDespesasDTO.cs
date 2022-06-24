using ControleDespesas.Models.Despesas;

namespace ControleDespesas.DTOs
{
    public class ListarDespesasDTO
    {
        public ListarDespesasDTO()
        {
            DataInicial = DateTime.UtcNow.AddDays(-7);
            DataFinal = DateTime.UtcNow.AddDays(2);
            Items = new List<Despesa>();
        }

        public DateTime DataInicial { get; set; } 
        public DateTime DataFinal { get; set; }   

        public List<Despesa> Items { get; set; }
    }
}
