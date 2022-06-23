using ControleDespesas.Infraestrutura.BancoDeDados;
using ControleDespesas.Models.Despesas;
using Microsoft.EntityFrameworkCore;

namespace ControleDespesas.Services
{
    public class DespesasService
    {
        private readonly DespesasContext _context;

        public DespesasService(DespesasContext context)
        {
            _context = context; 
        }

        public async Task Create(DTOs.CriarDespesasDTO createDespesasDTO)
        {
            await _context.Despesas.AddAsync(new Despesa()
            {
                Descricao = createDespesasDTO.Descricao,   
                Data =  createDespesasDTO.Data,
                Valor = createDespesasDTO.Valor
            });

            await _context.SaveChangesAsync();  
        }

        public async Task<List<Despesa>> FindBy(DateTime dataInicial, DateTime dataFinal)
        {
            var items = await _context.Despesas.Where(d => d.Data >= dataInicial && d.Data <= dataFinal).
                AsNoTracking().ToListAsync();

            return items;  
        }
    }
}
