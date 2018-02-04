using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using WebAPI.Controllers;
using Roshani.Provider.Contract;
using Roshani.Provider.User;
using Roshani.data.Contract;
using Roshani.data.provider;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Roshani.data.model;
using System.Threading.Tasks;

namespace RoshaniMSTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ValuesController _valuesController;
        public UnitTest1()
        {
            string constrg = "server=localhost;userid=Roshani;pwd=$Roshani123;port=3306;database=Roshani;sslmode=none;";
            IdatamodelContext datamodel = new dbContext(constrg);
            IUsersDetailsData userdetaildata = new RoshaniUserDto(datamodel);
            IUserDetailProvider detailprovider = new UserDetailProvider(userdetaildata);
            _valuesController = new ValuesController(detailprovider);
        }
        [TestMethod]
        public void TestMethod1()
        {
            var UserDetailPro = new Mock<IUserDetailProvider>();
            //UserDetailPro.Setup(Usr => Usr.GetUserDetails()).Returns(It.IsAny<List<UserModel>>());
            UserDetailPro.Setup(x=>x.GetUserDetails()).Returns(()=>new List<UserModel>(){new UserModel(){
                idRos_User=1,Email="ss" ,User_Name="aa"
            }});
            var UserController = new ValuesController(UserDetailPro.Object);
            var result = UserController.Get();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var UsrDtl = _valuesController.Get();
            Assert.IsNotNull(UsrDtl);
            /* foreach (var usrdata in UsrDtl)
            {
                Assert.AreEqual(usrdata.idRos_User, 1);
            } */
        }
        [TestMethod]
        public void ForValueController(){
            var ValueMock=new Mock<ValuesController>();
            //ValueMock.Setup(x=>x.Get(It.IsAny<int>())).Returns(()=>new List<UserModel>().Add();
        }
    }
}
