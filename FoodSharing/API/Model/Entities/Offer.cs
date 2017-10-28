using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repositories;

namespace API.Model.Entities
{
    public class Offer
    {
        public Guid OfferId { get; }
        public List<Guid> ProductIds { get; set; }
        public Guid OwnerId { get; set; }
        public string Address { get; set; }
        public List<TimeFrame> RecieveTimes { get; set; }
        public bool IsForFoundationOnly { get; set; }
        public string OfferDecsription { get; set; }
        public Uri OfferImage { get
            {
                return ProductRepository.Get(ProductIds.First()).ImageId;
            } }

        public string ExpirationDate
        {
            get
            {
                Guid minId = ProductIds.OrderByDescending(p => ProductRepository.Get(p).ExpirationDate).First();
                return ProductRepository.Get(minId).ExpirationDate.ToShortDateString();
            }
        }

        public Offer()
        {
            this.OfferId = Guid.NewGuid();
        }

        public DateTime CreationDate { get; set; }
    }
}
