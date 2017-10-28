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

        public static IList<Product> GetAll()
        {
            return products;
        }

        public static Product Get(Guid productId)
        {
            return products.First(p => p.ProductId == productId);
        }

        public static Guid Get(string name)
        {
            return products.First(p => p.Name == name).ProductId;
        }

        public static bool Add(Product product)
        {
            if (product.Name != null && product.Description != null && product.ExpirationDate != null)
            {
                products.Add(product);
                return true;
            }
            return false;
        }
    }
}
