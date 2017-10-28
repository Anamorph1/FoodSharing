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
           new User {
                    Name = "Kamil Makarowski",
                    Email = "michal.sliwa.93@outlook.com",
                    DefaultAddress = "Dziura w dupie 1/2",
                    IsFoundation = true,
                    Password = "XD"
                },
           new User {
               Name = "Adam Giża",
               Email = "adam.giza@gmail.com",
               DefaultAddress = "Dziura w dupie 2/1",
               IsFoundation = false,
               Password = "XD"
           }
        };

        internal static bool Add(User user)
        {
            if (user.Name != null && user.Password != null && user.Email != null)
            {
                users.Add(user);
                return true;
            }
            return false;
        }

        public static User Get(Guid userId)
        {
            return users.First(u => u.UserId == userId);
        }

        public static IList<User> GetAll()
        {
            return users;
        }
    }
}
