using BLL;
using BO;
using DAL.Abstract;
using DAL.DbModel;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.Tests
{
    [TestFixture]
    public class UserManagerTests
    {
        private Mock<IUserRepository> _userRepository;

        [SetUp]
        public void SetUp()
        {
            _userRepository = new Mock<IUserRepository>();
            _userRepository.Setup(u => u.GetUser(It.IsAny<string>())).Returns(new User { Username = "test", Password = "password" });
        }

        [Test]
        public void TestUserManager()
        {
            var manager = new AuthenticationManager(_userRepository.Object);            

            Assert.IsTrue(manager.Login("test", "password"));
            Assert.IsFalse(manager.Login("test", "wrongpassword"));
        }
    }
}
