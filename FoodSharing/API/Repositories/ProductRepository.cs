using API.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public static class ProductRepository
    {
        public static IList<Product> products = new List<Product>()
        {

        };

        public static void Add(Product product)
        {
            products.Add(product);
        }
    }
}
