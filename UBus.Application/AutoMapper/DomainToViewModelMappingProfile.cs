using UBus.Application.ViewModels;
using UBus.Domain.Models;
using AM = AutoMapper;

namespace UBus.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : AM.Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Funcionario, FuncionarioViewModel>().ReverseMap();
            CreateMap<Veiculo, VeiculoViewModel>()
                                .ForPath(o => o.ItensAdicionais, d => d.MapFrom(src => src.ItemAdicional));
            CreateMap<Rota, RotaViewModel>().ReverseMap();
            CreateMap<Itinerario, ItinerarioViewModel>().ReverseMap();
            CreateMap<Viagem, ViagemViewModel>().ReverseMap();
            CreateMap<ItemAdicional, ItemAdicionalViewModel>().ReverseMap();
        }
    }
}
