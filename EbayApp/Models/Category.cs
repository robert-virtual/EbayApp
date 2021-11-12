using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayApp.Models
{
    [Table("Categories")]
    public class Category: MyEntity<Category>
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        // relaciones
        [Write(false)]
        public List<Product> Products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
