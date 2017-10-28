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
            new Product {
                    ProductId = Guid.NewGuid(),
                    Name = "Frytki",
                    Description = "100g",
                    ImageId = Guid.NewGuid(),
                    ExpirationDate = DateTime.Now.AddHours(12)
            },
            new Product {
                    ProductId = Guid.NewGuid(),
                    Name = "Kurczak",
                    Description = "Żywy kurczak",
                    ImageId = Guid.NewGuid(),
                    ExpirationDate = DateTime.Now.AddHours(96)
            }
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

        public static void Add(Product product)
        {
            products.Add(product);
        }
    }
}
