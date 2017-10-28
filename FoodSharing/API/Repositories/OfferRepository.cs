using API.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class OfferRepository
    {
        public static IList<Offer> offers;

        public static IList<Offer> GetAll()
        {
            return offers;
        }

        public static Offer Get(Guid offerId)
        {
            return offers.First(o => o.OfferId == offerId);
        }

        public static void Create(Offer offer)
        {
            offers.Add(offer);
        }
    }


}
