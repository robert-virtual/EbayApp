using Dapper.Contrib.Extensions;
using EbayApp.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayApp.Models
{
    [Table("Products")]
    public class Product:ProdsController
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        //relacion
        [Write(false)]
        public Category Category { get; set; }

        public bool Activo { get; set; }

        [Write(false)]
        public DateTime CreatedAt { get; set; }
        public int CategoryFk { get; set; }

        //relacion
        [Write(false)]
        public List<SellDetail> SellDetails { get; set; }

         [Write(false)]
        public List<Purchase> Purchase { get; set; }


        public Product()
        {
            Activo = true;
            CreatedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
