using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionBooks.Controllers;
using System.Web.Mvc;
using System.Web;
using Moq;
using BookLayerApp.DAL.Interfaces;
using BookLayerApp.DAL.Entities;
using System.Collections.Generic;
using CollectionBooks.Models;

namespace CollectionBooks.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void CreatePostAction()
        {
            string expected = "Create";
            var mock = new Mock<IRepository>();
            Book book = new Book();
            HomeController controller = new HomeController(mock.Object);
            controller.ModelState.AddModelError("Name", "The model name is not set");

            ViewResult result = controller.Create(book) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.ViewName);
        }
        [TestMethod]
        public void CreatePostActionRedirect()
        {
            string expected = "Index";
            var mock = new Mock<IRepository>();
            Book book = new Book();
            HomeController controller = new HomeController(mock.Object);
            RedirectToRouteResult result = controller.Create(book) as RedirectToRouteResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.RouteValues["action"]);
        }
        [TestMethod]
        public void CreatePostActionSaveAddModel()
        {
            var mock = new Mock<IRepository>();
            Book book = new Book();
            HomeController controller = new HomeController(mock.Object);
            RedirectToRouteResult result = controller.Create(book) as RedirectToRouteResult;

            mock.Verify(b => b.Create(book));
            mock.Verify(b => b.Save());
        }
        [TestMethod]
        public void IndexViewSearch()
        {
            string searchString = "Java book";
            var mock = new Mock<IRepository>();
            mock.Setup(a => a.SearchAll(searchString)).Returns(new Book());
            HomeController controller = new HomeController(mock.Object);

            ViewResult result = controller.Index(searchString) as ViewResult;
            string actual = result.ViewBag.Message as string;

            //Assert.IsNotNull(result.Model);
            Assert.AreEqual(searchString, actual);
        }
    }
}
