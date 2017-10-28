using System;
using API.Model.StaticResources;

namespace API.Model.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Uri ImageId { get; }

        public Product()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, ProductImages.ImageCount);
            ImageId = ProductImages.ImageUris[index];
        }

    }
}
