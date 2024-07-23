using MapeamentoTerritorio.Models;

namespace MapeamentoTerritorio.Interfaces
{
    public interface IMapaService : IDisposable
    {
        Task AdicionarMapa(Mapa mapa);
        Task AdicionarQuadra(Quadra quadra);
        Task AdicionarRua(Rua rua);
        Task AdicionarCasa(Casa casa);

        Task AtualizarMapa(Mapa mapa);
        Task AtualizarQuadra(Quadra quadra);
        Task AtualizarRua(Rua rua);
        Task AtualizarCasa(Casa casa);

        Task RemoverMapa(Guid id);
        Task RemoverQuadra(Guid id);
        Task RemoverRua(Guid id);
        Task RemoverCasa(Guid id);
    }
}
