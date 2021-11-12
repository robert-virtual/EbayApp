using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayApp.Models
{
    [Table("SellDetails")]
    public class SellDetail
    {
        public int SellFk { get; set; }
        
        [Write(false)]
        public Sell Sell { get; set; }
        public int ProductFk { get; set; }
        
        [Write(false)]
        public Product Product { get; set; }

        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Descount { get; set; }

    }
}
