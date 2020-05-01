using System.Collections.Generic;
using Dal;
using Dal.DAL;
using Dal.memoryDB;
using Dal.models;
using NUnit.Framework;
using Dal.services;
using Moq;

namespace blogTest
{
    public class UserServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLogin()
        {
            // AAA
            // Arrange
            var fakeNormalUserRepo=new Mock<IRepository<NormalUser>>();
            
            NormalUser fakeUser = new NormalUser() {Email = "aia@mail.com", Password = "ahmed", Gender = "Female"};
            List<NormalUser> users = new List<NormalUser>() {fakeUser};

            fakeNormalUserRepo.Setup(p => p.Find(new NormalUser())).Returns(users);
            
            IRepository<NormalUser> normalUserRepo = new FakeRepo<NormalUser>();
            IRepository<LoginSession> loginSessionRepo = new MemoryDBRepository<LoginSession>();
            NormalUserService userService = new NormalUserService(fakeNormalUserRepo.Object, loginSessionRepo);

            // Act
            bool result = userService.Login("aia@mail.com", "ahmed");
            
            // Assert
            Assert.IsTrue(result);

        }
    }
}