using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Show(int id, string name, string Image)
        {
            Image image = new Image() { ID = id, Name = name, URL = Image };
            ViewBag.Image = image;
            return View();
        }
    }
}