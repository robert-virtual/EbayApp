using Dapper.Contrib.Extensions;
using EbayApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EbayApp.Models
{
    public class MyEntity<T>: Connection where T:class
    {
        //obtener todos los registros de productos
        public List<T> GetAll()
        {
            using (var db = ConnectDb())
            {
                return db.GetAll<T>().ToList();
            }
        }

        public long Save(T entity)
        {
            using (var db = ConnectDb())
            {
               return db.Insert(entity);
            }
        }


    }
}
