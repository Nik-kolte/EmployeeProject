using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeDbLayer
{
    class EmployeeModel
    {
        public int Id { get; set; }
        [Required()]
        public string Name { get; set; }
        [Required()]
        public string Gender { get; set; }
        [Required()]
        public string Cadre { get; set; }
        public string Image { get; set; }
    }
}
