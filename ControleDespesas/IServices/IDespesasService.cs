using ControleDespesas.Models.Despesas;

namespace ControleDespesas.IServices
{
    public interface IDespesasService
    {
        /// <summary>
        /// Cria uma nova despesa que será adiciona ao banco de dados
        /// </summary>
        /// <param name="createDespesasDTO"></param>
        /// <returns></returns>
        Task Create(DTOs.CriarDespesasDTO createDespesasDTO);
        /// <summary>
        /// Lista as despesas entre a data inicial e a data final
        /// </summary>
        /// <param name="dataInicial"></param>
        /// <param name="dataFinal"></param>
        /// <returns>Despesas cadastradas no intervalo</returns>
        Task<List<Despesa>> FindBy(DateTime dataInicial, DateTime dataFinal);
    }
}
