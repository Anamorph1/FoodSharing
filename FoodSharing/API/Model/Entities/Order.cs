using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public IEnumerable<Guid> OfferIds { get; set; }
        public Guid OwnerId { get; set; }

        public void AddOffer(Offer offer)
        {

        }

        public void ConfirmOffer(User user)
        {
            foreach(var offerId in user.Offers.Where(o => Offers.Contains(o.OfferId)).Select(o => o.OfferId))
            {
                user.Offers.FirstOrDefault(o => o.OfferId == offerId).State = Enums.OfferState.Reserved;
            }
            NotificationManager.ConfirmOrder(user);
        }


    }
}
