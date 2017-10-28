using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DefaultAddress { get; set; }
        public bool IsFoundation { get; set; }
        public List<Offer> Offers {get; set; }

    }
}
