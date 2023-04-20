using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult getAll()
        {
             ViewBag.Cars = CarList.Cars;
            
            return View();
        }
        public ActionResult getById(int id)
        {
            ViewData["Car"] = CarList.Cars.FirstOrDefault(e => e.Num == id);

            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.curCar = CarList.Cars.FirstOrDefault(e => e.Num == id);

            return View();
        }
        public ActionResult EditSave(int Number, string Color ,string Model ,string Manfacture)
        {
            var updateCar = CarList.Cars.FirstOrDefault(e => e.Num == Number);

            updateCar.Color = Color;
            updateCar.Model = Model;
            updateCar.Manfacture = Manfacture;

            

            return RedirectToAction("getAll");
        }

        public ActionResult Delete(int id)
        {
            Car curCar  = CarList.Cars.FirstOrDefault(e => e.Num == id);
            CarList.Cars.Remove(curCar);

            return RedirectToAction("getAll");
        }

        public ActionResult Create() // create view
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Color, string Model, string Manfacture) // create
        {
            Car newCar = new Car() { Num = CarList.Cars.Count + 1, Color = Color, Model = Model, Manfacture = Manfacture };
            CarList.Cars.Add(newCar);
            return RedirectToAction("getAll");
        }


    }
}