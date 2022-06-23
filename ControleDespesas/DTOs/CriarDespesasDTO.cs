using System.ComponentModel.DataAnnotations;

namespace ControleDespesas.DTOs
{
    public class CriarDespesasDTO
    {
        [Required(ErrorMessage ="A descrição é necessária!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="O valor é necessário!")]
        [Range(0.01, 99999999, ErrorMessage="O valor informado deve ser maior que 0!")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "A data é necessária!")]
        public DateTime Data { get; set; }
    }
}
