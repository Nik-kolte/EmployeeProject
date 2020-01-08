using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer
{
    public class DataOps
    {
        //public SqlConnection connectionString = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"].ToString());
        private DbEmpContext _context;

        public DataOps()
        {
            _context = new DbEmpContext();
        }


        public IEnumerable<Emp> GetAllEmployees()
        {

            var employees = _context.Emps.ToList();
            return employees;
        }

        public Emp GetEmployee(int id)
        {
            var employee = _context.Emps.SingleOrDefault(c => c.Id == id);
            return employee;
        }

        public bool AddEmployee(Emp employee)
        {
            //try
            //{
                _context.Emps.Add(employee);
                _context.SaveChanges();
                return true;
            //}
            //catch (Exception e)
            //{
              //  return false;
            //}
        }

        public bool EditEmployee(int id, Emp employee)
        {
            var employeeInDb = _context.Emps.SingleOrDefault(c => c.Id == id);

            if (employeeInDb == null)
                return false;
            employeeInDb.Name = employee.Name;
            employeeInDb.Image = employee.Image;
            employeeInDb.Gender = employee.Gender;
            employeeInDb.Cadre = employee.Cadre;
            _context.SaveChanges();
            return true;
        }


        public bool DeleteEmployee(int id)
        {
            var employeeInDb = _context.Emps.SingleOrDefault(c => c.Id == id);

            if (employeeInDb == null)
                return false;
            try
            {
                _context.Emps.Remove(employeeInDb);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
