﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalanceManager;
using BalanceManager.Controllers;

namespace BalanceManager.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            UserController controller = new UserController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}