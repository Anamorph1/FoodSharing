using API.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public static class UserRepository
    {
        public static IList<User> users = new List<User>()
        {
            new User()
            {
                UserId = Guid.NewGuid(),
                Name = "StandardUser"
            },
            new User()
            {
                UserId = Guid.NewGuid(),
                Name = "FoundUser",
                IsFoundation = true
            }
        };

        public static Guid Get(string name)
        {
            return users.First(u => u.Name == name).UserId;
        }
    }
}
