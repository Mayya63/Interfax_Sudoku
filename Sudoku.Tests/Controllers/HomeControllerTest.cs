using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku;
using Sudoku.Controllers;

namespace Sudoku.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Упорядочение
            /*
            Controller controller = new HomeController();

            // Действие
            ViewResult result = controller.Index() as ViewResult;

            // Утверждение
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
            */
        }
    }
}
