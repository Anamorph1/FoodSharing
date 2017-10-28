using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Dictionary<User, List<Offer>> OrderLine { get; set; }
        public User Owner { get; set; }

        public void AddOffer(Offer offer)
        {
            if (OrderLine == null)
                OrderLine = new Dictionary<User, List<Offer>>();
            if (!OrderLine.ContainsKey(offer.Owner))
                OrderLine.Add(offer.Owner, new List<Offer>());
            OrderLine[offer.Owner].Add(offer);
        }
    }
}
