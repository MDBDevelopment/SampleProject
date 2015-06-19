using BLL.Abstract;
using DAL.Abstract;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationManager()
        {
            _userRepository = new InMemoryUserRepository();
        }

        public AuthenticationManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool Login(string username, string password)
        {
            var user = _userRepository.GetUser(username);

            return user.Password == password;
        }
    }
}
