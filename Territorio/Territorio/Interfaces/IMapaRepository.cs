using MapeamentoTerritorio.Models;

namespace MapeamentoTerritorio.Interfaces
{
    public interface IMapaRepository
    {
        Task<IEnumerable<Mapa>> ObterTodosMapasAsync();
        Task<Mapa> ObterMapaPorId(int id);
        Task<Mapa> AdicionarMapa(Mapa mapa);
        Task<Mapa> AtualizarMapa(Mapa mapa);
        Task RemoverMapa(int id);
    }
}
