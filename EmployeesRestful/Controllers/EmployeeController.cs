using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeLogicLayer;
using EmpDto;

namespace EmployeesRestful.Controllers
{
    public class EmployeeController : ApiController
    {
        LogicFunction b_layer = new LogicFunction();

        // GET: api/Employee/
        public IEnumerable<EmployeeDto> Get()
        {
            return b_layer.getAllEmployees();
        }

        // GET: api/Employee/5
        public EmployeeDto Get(int id)
        {
            return b_layer.getEmployee(id);
        }

        // POST: api/Employee
        public string Post(EmployeeDto employeeDto)
        {
            if (b_layer.AddEmployee(employeeDto))
            {
                return "Success";
            }
            return "Invalid";
        }

        // PUT: api/Employee/5
        public string Put(int id, [FromBody]EmployeeDto employeeDto)
        {
            if (b_layer.EditEmployee(employeeDto, id))
            {
               return "Success";
            }
            return "Invalid";
        }

        // DELETE: api/Employee/5
        public string Delete(int id)
        {
            //if (b_layer.DeleteEmployee(id))
            //{
            //    return "Success";
            //}
            return "bye";

        }
    }
}
