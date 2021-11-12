using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayApp.Models
{
    [Table("Customers")]
    public class Customer
    {
        [ExplicitKey]
        public string DNI { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        
        // relaciones
        [Write(false)]
        public List<Sell> Sells { get; set; }


        public Customer()
        {
            CreatedAt = DateTime.Now;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
