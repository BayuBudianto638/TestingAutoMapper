using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAutoMapper.Models;
using TestingAutoMapper.ViewModels;

namespace TestingAutoMapper.Configuration
{
    public class ConfigProfile : Profile
    {
        public ConfigProfile()
        {
            CreateMap<BaseClassVM, ClassA>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<ClassA, BaseClassVM>();

            CreateMap<ClassB, ClassVM>();
            CreateMap<ClassVM, ClassB>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }


    }
}
