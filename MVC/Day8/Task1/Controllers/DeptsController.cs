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
    public class DeptsController : Controller
    {
        private readonly EMPLOYEESContext _context;

        public DeptsController(EMPLOYEESContext context)
        {
            _context = context;
        }

        // GET: Depts
        public ActionResult Index()
        {
            return View( _context.Depts.ToList());
        }

        // GET: Depts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dept =  _context.Depts
                .FirstOrDefault(m => m.DeptId == id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        // GET: Depts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Depts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("DeptId,DeptName,DeptDesc")] Dept dept)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dept);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(dept);
        }

        // GET: Depts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dept =  _context.Depts.Find(id);
            if (dept == null)
            {
                return NotFound();
            }
            return View(dept);
        }

        // POST: Depts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("DeptId,DeptName,DeptDesc")] Dept dept)
        {
            if (id != dept.DeptId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dept);
                     _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeptExists(dept.DeptId))
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
            return View(dept);
        }

        // GET: Depts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dept =  _context.Depts
                .FirstOrDefault(m => m.DeptId == id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }

        // POST: Depts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var dept =  _context.Depts.Find(id);
            _context.Depts.Remove(dept);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool DeptExists(int id)
        {
            return _context.Depts.Any(e => e.DeptId == id);
        }
    }
}
