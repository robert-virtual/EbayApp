using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayApp.Models
{
    [Table("Roles")]
    public class Rol
    {
        [Key]
        public int RolId { get; set; }
        public string Name { get; set; }
        
        [Write(false)]
        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
