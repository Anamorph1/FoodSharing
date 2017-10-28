using API.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class OfferRepository
    {
        public IList<Offer> offers;

        public IList<Offer> GetAll()
        {
            return offers;
        }

        public Offer Get(Guid offerId)
        {
            return offers.First(o => o.OfferId == offerId);
        }

        public void Create(Offer offer)
        {
            offers.Add(offer);
        }
    }


}
