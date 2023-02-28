using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{


    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/")]
        public ActionResult Create(string color, float price)
        {
          Car userCar = new Car(color);
          return RedirectToAction("Index");
        }
        
        // route for /new with form on it

        [HttpGet("/new")]
        public ActionResult AddCarForm()
        {
          return View();
        }
    }
}