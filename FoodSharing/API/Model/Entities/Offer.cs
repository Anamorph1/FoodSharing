using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Enums;

namespace API.Model.Entities
{
    public class Offer
    {
        public Guid OfferId { get; set; }
        public List<Guid> ProductIds { get; set; }
        public Guid OwnerId { get; set; }
        public string Address { get; set; }
        public List<TimeFrame> RecieveTimes { get; set; }
        public bool IsForFoundationOnly { get; set; }
        public OfferState State { get; set; }
        //public User AcceptingUser { get; set; }

        public void AddProduct(Product product)
        {
            //if (Products == null)
            //    Products = new List<Product>();
            //Products.Add(product);
        }

        public void AddTimeFrame(TimeFrame timeFrame)
        {
            //if (RecieveTimes == null)
            //    RecieveTimes = new List<TimeFrame>();
            //RecieveTimes.Add(timeFrame);
        }

    }
}
