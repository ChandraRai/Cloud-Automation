using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoleAuth.Models
{
    public class EmployeeType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string PayType { get; set; }
    }

}
