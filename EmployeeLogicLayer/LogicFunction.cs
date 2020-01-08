using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using System.Configuration;
using DbLayer;
using EmpDto;
using Mapster;

namespace EmployeeLogicLayer
{
 
    public class LogicFunction
    {
        DataOps db = new DataOps();
        public LogicFunction()
        {
            TypeAdapterConfig<Emp, EmployeeDto>.NewConfig();
            TypeAdapterConfig<EmployeeDto,Emp>.NewConfig().Ignore(dest => dest.Id); ;
        }
        public IEnumerable<EmployeeDto> getAllEmployees()
        {
            var employees = db.GetAllEmployees();
            var employeeDto = employees.Adapt<IEnumerable<EmployeeDto>>();
            return employeeDto;
        }
        
        public EmployeeDto getEmployee(int id)
        {
            var employee = db.GetEmployee(id);
            return employee.Adapt<EmployeeDto>();
            
        }
        
        public bool AddEmployee(EmployeeDto employeeDto)
        {

            var employee = employeeDto.Adapt<Emp>();
            try
            {
                db.AddEmployee(employee);
                return true;
            }
            catch (Exception e)
            {
               return false;
            }
        }
        
        public bool EditEmployee(EmployeeDto employeeDto, int id)
        {
            var employee = employeeDto.Adapt<Emp>();
            try
            {
                db.EditEmployee(id, employee);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                db.DeleteEmployee(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
    }
}
