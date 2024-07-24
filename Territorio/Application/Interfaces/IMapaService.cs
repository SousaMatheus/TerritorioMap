using Application.ViewModels;
using ViewModels;

namespace Application.Interfaces
{
    public interface IMapaService : IDisposable
    {
        Task<IEnumerable<MapaViewModel.Retorno>> ObterMapasAsync();
        Task<IEnumerable<MapaViewModel.Retorno>> ObterQuadrasAsync();
        Task<IEnumerable<MapaViewModel.Retorno>> ObterRuasAsync();
        Task<IEnumerable<MapaViewModel.Retorno>> ObterCasasAsync();

        Task AdicionarMapa(MapaViewModel.Envio mapa);
        Task AdicionarQuadra(QuadraViewModel.Envio quadra);
        Task AdicionarRua(RuaViewModel.Envio rua);
        Task AdicionarCasa(CasaViewModel.Envio casa);

        Task AtualizarMapa(MapaViewModel.Envio mapa);
        Task AtualizarQuadra(QuadraViewModel.Envio quadra);
        Task AtualizarRua(RuaViewModel.Envio rua);
        Task AtualizarCasa(CasaViewModel.Envio casa);

        Task RemoverMapa(Guid id);
        Task RemoverQuadra(Guid id);
        Task RemoverRua(Guid id);
        Task RemoverCasa(Guid id);
    }
}
