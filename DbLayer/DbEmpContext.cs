using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer
{
    public class DbEmpContext : DbContext
    {
        public DbSet<Emp> Emps { get; set; }
    }
}
