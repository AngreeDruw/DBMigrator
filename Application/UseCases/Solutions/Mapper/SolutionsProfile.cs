using ApplicationLayer.UseCases.Solutions.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace ApplicationLayer.UseCases.Solutions.Mapper
{
    public class SolutionsProfile : Profile
    {
        public SolutionsProfile() 
        {
            CreateMap<Solution, SolutionsViewModel>();
        }
    }
}
