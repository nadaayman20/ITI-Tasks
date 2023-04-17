using Day6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Day6.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Client c)
        {

            if (ModelState.IsValid)
            {
                MainDbContext context = new MainDbContext();

                context.Clients.Add(c);
                context.SaveChanges();

                var userIdentity = new ClaimsIdentity(
                new List<Claim>()
                {
                        new Claim(ClaimTypes.Email, c.Email),
                        new Claim("Name", c.Name),
                        new Claim("Password", c.Password)
                }, "AppCookie");

                Request.GetOwinContext().Authentication.SignIn(userIdentity);  ///OWIN authentication manager

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Client c)
        {
            MainDbContext context = new MainDbContext();
            var loggedUser = context.Clients.FirstOrDefault(
                u => u.Email == c.Email && u.Password == c.Password);

            if (loggedUser != null)
            {
                var signInIdentity = new ClaimsIdentity(
                    new List<Claim>()
                    {
                        new Claim(ClaimTypes.Email, loggedUser.Email),
                        new Claim("Password", loggedUser.Password)
                    }, "AppCookie");

                Request.GetOwinContext().Authentication.SignIn(signInIdentity);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Name", "User is not Existed!");
                return View();
            }
        }


        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("AppCookie");  ///OWIN authentication manager
            return RedirectToAction("Login");
        }
    }
}