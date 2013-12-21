//using System.Web.Http.Results;
//using CodeArt.DomainServices.Contracts.Models.Membership;
//using CodeArt.WebApi.Controllers;
//using Microsoft.AspNet.Identity;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;

//namespace CodeArt.WebApi.Tests.Controllers
//{
//    [TestClass]
//    public class MembershipControllerTests
//    {
//        private Mock<UserModel> applicationUserModelMock;
//        private Mock<UserManager<UserModel>> userManangerMock;
//        private Mock<UserValidator<UserModel>> userValidatorMock;
//        private MembershipController membershipController;
        
//        [TestInitialize]
//        public void Initializer()
//        {
//            applicationUserModelMock = new Mock<UserModel>();
//            userManangerMock = new Mock<UserManager<UserModel>>();
//            userValidatorMock = new Mock<UserValidator<UserModel>>();
//            membershipController = new MembershipController(userManangerMock.Object, userValidatorMock.Object);
//        }

//        [TestMethod]
//        public void Register_ReturnsNull_ReturnsErrorResult()
//        {
//            Arrange_Register_ReturnsNull_ReturnsInternalServerError();
//            var rezult = membershipController.Register(applicationUserModelMock.Object);
//            Assert.AreEqual(typeof(InternalServerErrorResult), rezult.GetType());
//        }

//        private void Arrange_Register_ReturnsNull_ReturnsInternalServerError()
//        {
//            IdentityResult userRegistrationResultModel = null;
//            userManangerMock.Setup(x => x.Create(It.IsAny<UserModel>()))
//                                 .Returns(userRegistrationResultModel);
//        }

//        [TestMethod]
//        public void Register_ReturnsSuccededFalse_ReturnsBadRequest()
//        {
//            Arrange_Register_ReturnsSuccededFalse_ReturnsBadRequest();
//            var rezult = membershipController.Register(applicationUserModelMock.Object);
//            Assert.AreEqual(typeof(BadRequestResult), rezult.GetType());
//        }

//        private void Arrange_Register_ReturnsSuccededFalse_ReturnsBadRequest()
//        {
//            //var userRegistrationResultModel = new IdentityResult
//            //{
//            //    Succeeded = false,
//            //    Errors = null
//            //};
//            membershipServiceMock.Setup(x => x.RegisterUser(It.IsAny<UserModel>()))
//                                 .Returns(userRegistrationResultModel);
//        }

//        [TestMethod]
//        public void Register_ReturnsSuccededTrue_ReturnsOk()
//        {
//            Arrange_Register_ReturnsSuccededTrue_ReturnsOk();
//            var rezult = membershipController.Register(applicationUserModelMock.Object);
//            Assert.AreEqual(typeof(OkResult), rezult.GetType());
//        }

//        private void Arrange_Register_ReturnsSuccededTrue_ReturnsOk()
//        {
//            var userRegistrationResultModel = new UserRegistrationResultModel()
//            {
//                Succeeded = true,
//                Errors = null
//            };
//            membershipServiceMock.Setup(x => x.RegisterUser(It.IsAny<UserModel>()))
//                                 .Returns(userRegistrationResultModel);
//        }
//    }
//}
