using AutoMapper;
using Finance.Application.Dto;
using Finance.Domain.Entity;

namespace Finance.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
        }
    }
}
