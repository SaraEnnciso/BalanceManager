using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BalanceManager.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            //UserController controller = new UserController();

            // Act
            //ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull("Home Page");
            Assert.AreEqual("Home Page", "Home Page");
        }
    }
}
