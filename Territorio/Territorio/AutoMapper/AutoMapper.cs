using AutoMapper;
using MapeamentoTerritorio.Models;
using MapeamentoTerritorio.ViewModels;

namespace MapeamentoTerritorio.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Mapa, MapaViewModel>().ReverseMap();
            CreateMap<Quadra, QuadraViewModel>().ReverseMap();
            CreateMap<Rua, RuaViewModel>().ReverseMap();
            CreateMap<Casa, CasaViewModel>().ReverseMap();
        }
    }
}
