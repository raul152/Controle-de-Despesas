using System.ComponentModel.DataAnnotations;

namespace ControleDespesas.Models.Despesas
{
    public class Despesa
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
