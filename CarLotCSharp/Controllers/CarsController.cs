using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
          List<Car> allCars = Car.GetAllCars();
          return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult NewCarForm()
        {
          return View();
        }

        [HttpPost("/cars")]
        public ActionResult NewCar(string makeModel, int miles, int price, string description)
        {
          Car newCar = new Car(makeModel, miles, price, description);
          return RedirectToAction("Index");
        }
    }
}
