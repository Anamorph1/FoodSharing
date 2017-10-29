using System;
using API.Model.StaticResources;

namespace API.Model.Entities
{
    public class Product
    {
        public Guid ProductId { get; }
        public string Name { get; set; }
        public string ExpirationDate { get; set; }
        public Uri ImageId { get; }

        public Product()
        {
            this.ProductId = Guid.NewGuid();
            Random rnd = new Random();
            int index = rnd.Next(0, ProductImages.ImageCount);
            ImageId = ProductImages.ImageUris[index];
        }

    }
}
