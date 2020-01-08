using AutoMapper;
using System;

namespace EmployeeLogicLayer
{
    public class Class1
    {
        IMapper iMapper;
        public void LogicFunction()
        {
            var config = new MapperConfiguration(cfg => {
                //cfg.CreateMap<Emp, EmployeeDto>();
                //cfg.CreateMap<EmployeeDto, Emp>().ForMember(c => c.Id, opt => opt.Ignore());
            });
            iMapper = config.CreateMapper();
        }
    }
}
