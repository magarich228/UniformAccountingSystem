using AutoMapper;
using AutoMapper.Extensions.EnumMapping;
using UniformAccountingSystem.BLL.Dtos;
using UniformAccountingSystem.Data.Entities;

namespace UniformAccountingSystem.BLL.Profiles
{
    public class UniformProfile : Profile
    {
        public UniformProfile()
        {
            //CreateMap<Dtos.UniformType, Data.Entities.UniformType>()
            //    .ConvertUsingEnumMapping();

            //CreateMap<Uniform, UniformDto>()
            //    .ForMember(u => u.Id, opt => opt.MapFrom(u => u.Id))
            //    .ForMember(u => u.Name, opt => opt.MapFrom(u => u.Name))
            //    .ForMember(u => u.Price, opt => opt.MapFrom(u => u.Price))
            //    .ForMember(u => u.UniformType, opt => opt.MapFrom(u => Enum.Parse<Dtos.UniformType>(u.UniformType.ToString())))
            //    .ReverseMap();
        }
    }
}
