using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayApp.Models
{
    [Table("Employees")]
    public class Employee
    {
        [ExplicitKey]
        public string DNI { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone  { get; set; }

        public string Address { get; set; }
        public int RolFk { get; set; }
        
        [Write(false)]
        public Rol Rol { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime HiredAt { get; set; }
        public DateTime FiredAt { get; set; }
        public bool Activo  { get; set; }

        //relacion
        [Write(false)]
        public List<Sell> Sells { get; set; }


        public Employee()
        {
            Birthday = DateTime.Now.AddYears(-18);
            HiredAt = DateTime.Now;
            FiredAt = DateTime.Now.AddYears(5);

            Activo = true;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
