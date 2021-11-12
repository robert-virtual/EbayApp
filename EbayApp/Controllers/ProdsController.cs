using Dapper.Contrib.Extensions;
using EbayApp.DataAccess;
using EbayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EbayApp.Controllers
{
    public class ProdsController:MyEntity<Product>
    {
        public List<Product> IncludeCats()
        {
            using (var db = ConnectDb())
            {

                var cats = db.GetAll<Category>().ToList();
                var prods = db.GetAll<Product>().ToList();
                var list = prods.ConvertAll(prod =>
                   {
                       prod.Category = cats.Find(cat => cat.CategoryId == prod.CategoryFk);
                   
                       return prod;
                   });
                return list; 
            }
        }
    }
}
