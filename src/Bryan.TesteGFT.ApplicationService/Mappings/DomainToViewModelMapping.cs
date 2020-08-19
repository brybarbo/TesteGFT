using Bryan.TesteGFT.ApplicationService.ViewModels;
using AutoMapper;
using Bryan.TesteGFT.Domain.Models;

namespace Bryan.TesteGFT.ApplicationService.Mappings
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<Trade, TradeCategoryViewModel>();
        }
    }
}