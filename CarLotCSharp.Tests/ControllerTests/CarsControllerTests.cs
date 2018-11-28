using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Controllers;
using Dealership.Models;

namespace Dealership.Tests
{
    [TestClass]
    public class CarsControllerTest
    {

    [TestMethod]
    public void Index_HasCorrectModelType_CarList()
    {
        //Arrange
        CarsController controller = new CarsController();
        ViewResult indexView = new CarsController().Index() as ViewResult;

        //Act
        var result = indexView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(List<Car>));
    }

  }
}
