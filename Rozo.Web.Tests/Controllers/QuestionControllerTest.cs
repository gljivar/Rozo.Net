using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rozo.Web.Controllers.Api;
using Rozo.Db;
using Rozo.Model;
using Rozo.DTO;

namespace Rozo.Web.Tests.Controllers
{
    [TestClass]
    public class QuestionControllerTest
    {
        [TestMethod]
        public void Get()
        {
            //// Arrange
            //QuestionsController controller = new QuestionsController(new QuestionRepository());

            //// Act
            //IEnumerable<QuestionBaseDTO> result = controller.Get();

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void GetById()
        {
            //// Arrange
            //QuestionsController controller = new QuestionsController(new QuestionRepository());

            //// Act
            //var result = controller.Get(0);

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Post()
        {
            //// Arrange
            //ValuesController controller = new ValuesController();

            //// Act
            //controller.Post("value");

            //// Assert
        }

        [TestMethod]
        public void Put()
        {
            //// Arrange
            //ValuesController controller = new ValuesController();

            //// Act
            //controller.Put(5, "value");

            //// Assert
        }

        [TestMethod]
        public void Delete()
        {
            //// Arrange
            //ValuesController controller = new ValuesController();

            //// Act
            //controller.Delete(5);

            //// Assert
        }
    }
}
