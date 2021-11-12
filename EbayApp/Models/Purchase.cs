using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayApp.Models
{
    [Table("Purchases")]

    public class Purchase
    {
        [Key]
        public int SupplierFk { get; set; }
        
        [Write(false)]
        public Supplier Supplier { get; set; }
        public int ProductFk { get; set; }
        
        [Write(false)]
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

    }
}
