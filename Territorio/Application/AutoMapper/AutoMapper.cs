using Application.ViewModels;
using AutoMapper;
using Domain.Models;
namespace Application.AutoMapper
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
