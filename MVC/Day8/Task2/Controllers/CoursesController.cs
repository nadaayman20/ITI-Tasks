using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Task2.Models;


namespace Task2.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CrsStudentsDBContext _context;

        public CoursesController(CrsStudentsDBContext context)
        {
            _context = context;
        }

        // GET: Courses
        public ActionResult Index()
        {
            return View(_context.Course.Include(C=>C.Student).ToList());
        }

        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course =  _context.Course
                .FirstOrDefault(m => m.ID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Name");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ID,Topic,CourseGrade,StudentID")] Course course)
        {
            if (ModelState.IsValid)
            {
                ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Name",course.StudentID);
                _context.Add(course);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course =  _context.Course.Find(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Name", course.StudentID);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("ID,Topic,CourseGrade,StudentID")] Course course)
        {
            if (id != course.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.ID))
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
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Name", course.StudentID);
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course =  _context.Course
                .FirstOrDefault(m => m.ID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var course =  _context.Course.Find(id);
            _context.Course.Remove(course);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.ID == id);
        }
    }
}
