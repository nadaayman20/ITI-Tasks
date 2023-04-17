using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Task1.Models;


namespace Task1.Controllers
{
    public class CitiesController : Controller
    {
        private readonly EMPLOYEESContext _context;

        public CitiesController(EMPLOYEESContext context)
        {
            _context = context;
        }

        // GET: Cities
        public ActionResult Index()
        {
            var eMPLOYEESContext = _context.Cities.Include(c => c.CIdNavigation);
            return View( eMPLOYEESContext.ToList());
        }

        // GET: Cities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city =  _context.Cities
                .Include(c => c.CIdNavigation)
                .FirstOrDefault(m => m.CityId == id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // GET: Cities/Create
        public ActionResult Create()
        {
            ViewData["CId"] = new SelectList(_context.Countries, "CountryId", "CountryName");
            return View();
        }

        // POST: Cities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("CityId,CityName,CId")] City city)
        {
            if (ModelState.IsValid)
            {
                _context.Add(city);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CId"] = new SelectList(_context.Countries, "CountryId", "CountryName", city.CId);
            return View(city);
        }

        // GET: Cities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city =  _context.Cities.Find(id);
            if (city == null)
            {
                return NotFound();
            }
            ViewData["CId"] = new SelectList(_context.Countries, "CountryId", "CountryName", city.CId);
            return View(city);
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("CityId,CityName,CId")] City city)
        {
            if (id != city.CityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(city);
                     _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityExists(city.CityId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CId"] = new SelectList(_context.Countries, "CountryId", "CountryName", city.CId);
            return View(city);
        }

        // GET: Cities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city =  _context.Cities
                .Include(c => c.CIdNavigation)
                .FirstOrDefault(m => m.CityId == id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var city =  _context.Cities.Find(id);
            _context.Cities.Remove(city);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool CityExists(int id)
        {
            return _context.Cities.Any(e => e.CityId == id);
        }
    }
}
