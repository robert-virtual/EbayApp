using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayApp.Models
{
    [Table("Sells")]
    public class Sell
    {
        [Key]
        public int SellId { get; set; }
        public int EmployeeId { get; set; }

        [Write(false)]
        public Employee Employee { get; set; }
        public int CustomerId { get; set; }
        
        [Write(false)]
        public Customer Customer { get; set; }
        public DateTime CreatedAt { get; set; }

        //relacion
        [Write(false)]
        public List<SellDetail> SellDetails { get; set; }


        public Sell()
        {
            CreatedAt = DateTime.Now;
        }

    }
}
