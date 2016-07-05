using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {
        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product {Id=1, Description = "Cristal", Price = 2.5 , CreateDate = DateTime.Now},
                new Product {Id=2, Description = "Pilsen", Price = 0.0 , CreateDate = null},
                new Product {Id=3, Description = "Cuzqueña", Price = 5.0 , CreateDate = DateTime.Now}
            };
        }

        public Product GetProductById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Products.FirstOrDefault(s => s.Id == id);
                //return dbContext.Clients.Find(id);
            }

        }
    }
}
