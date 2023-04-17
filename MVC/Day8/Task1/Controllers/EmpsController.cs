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
    public class EmpsController : Controller
    {
        private readonly EMPLOYEESContext _context;

        public EmpsController(EMPLOYEESContext context)
        {
            _context = context;
        }

        // GET: Emps
        public ActionResult Index()
        {
            var eMPLOYEESContext = _context.Emps.Include(e => e.DIdNavigation);
            return View( eMPLOYEESContext.ToList());
        }

        // GET: Emps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emp =  _context.Emps
                .Include(e => e.DIdNavigation)
                .FirstOrDefault(m => m.EmpId == id);
            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        // GET: Emps/Create
        public ActionResult Create()
        {
            ViewData["DId"] = new SelectList(_context.Depts, "DeptId", "DeptName");
            return View();
        }

        // POST: Emps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("EmpId,EmpFname,EmpLname,EmpSalary,EmpHdate,DId,CtyId")] Emp emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emp);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DId"] = new SelectList(_context.Depts, "DeptId", "DeptName", emp.DId);
            return View(emp);
        }

        // GET: Emps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emp =  _context.Emps.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            ViewData["DId"] = new SelectList(_context.Depts, "DeptId", "DeptName", emp.DId);
            return View(emp);
        }

        // POST: Emps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("EmpId,EmpFname,EmpLname,EmpSalary,EmpHdate,DId,CtyId")] Emp emp)
        {
            if (id != emp.EmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emp);
                     _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpExists(emp.EmpId))
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
            ViewData["DId"] = new SelectList(_context.Depts, "DeptId", "DeptName", emp.DId);
            return View(emp);
        }

        // GET: Emps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emp =  _context.Emps
                .Include(e => e.DIdNavigation)
                .FirstOrDefault(m => m.EmpId == id);
            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        // POST: Emps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var emp =  _context.Emps.Find(id);
            _context.Emps.Remove(emp);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpExists(int id)
        {
            return _context.Emps.Any(e => e.EmpId == id);
        }
    }
}
