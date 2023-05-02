using AutoMapper;
using AutoMapper.Extensions.EnumMapping;

namespace UniformAccountingSystem.BLL.Profiles
{
    public class UniformProfile : Profile
    {
        public UniformProfile()
        {
            CreateMap<Dtos.UniformType, Data.Entities.UniformType>()
                .ConvertUsingEnumMapping(opt => opt.MapByName())
                .ReverseMap();
        }
    }
}
