using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using EmpDto;
using DbLayer;

namespace EmployeeLogicLayer
{
    public static class Mapping
    {
            private static readonly Lazy<IMapper> AutoMapper = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg => {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

            public static IMapper Mapper => AutoMapper.Value;
        }

        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Emp, EmployeeDto>();
                CreateMap<EmployeeDto, Emp>()
                    .ForMember(c => c.Id, opt => opt.Ignore());
            }
        }
}

