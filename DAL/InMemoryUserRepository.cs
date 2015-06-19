using BO;
using DAL.Abstract;
using DAL.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InMemoryUserRepository : IUserRepository
    {
        private List<User> users = new List<User> { 
            new User{
                Id = 1,
                Username = "user@moneydashboard.com",
                Password = "MyPassword01"
            }
        };

        public User GetUser(string email)
        {
            return users.FirstOrDefault(u => u.Username == email);
        }
    }
}
