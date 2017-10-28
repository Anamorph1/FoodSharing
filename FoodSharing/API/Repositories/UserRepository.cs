using API.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public static class UserRepository
    {
        public static IList<User> users { get; }
    }
}
