﻿using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppExample.Controllers;

namespace WebAppExample.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            var enumerable = result as string[] ?? result.ToArray();
            Assert.AreEqual(2, enumerable.Count());
            Assert.AreEqual("value1", enumerable.ElementAt(0));
            Assert.AreEqual("value2", enumerable.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
