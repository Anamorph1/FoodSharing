using API.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class ProductRepository
    {
        IList<Product> products;

        public void Add(Product product)
        {
            products.Add(product);
        }
    }
}
