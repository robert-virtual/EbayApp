using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayApp.Models
{
    [Table("Suppliers")]
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string Name { get; set; }

        //relacion
        [Write(false)]
        public List<Purchase> Purchases { get; set; }
    }
}
