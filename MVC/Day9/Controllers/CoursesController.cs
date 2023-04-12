using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Day9.Models;
using Day9.RepoServices;

namespace Day9.Controllers
{
    public class CoursesController : Controller
    {
        public ITraineeRepository TraineeRepo { get; }
        public ITrackRepository TrackRepo { get; }
        public ICourseRepository CourseRepo { get; }
        public TraineesDB Cont { get; }

        public CoursesController(ITraineeRepository TRepo, ITrackRepository KRepo, ICourseRepository CRepo, TraineesDB cont)
        {
            TraineeRepo = TRepo;
            TrackRepo = KRepo;
            CourseRepo = CRepo;
            Cont = cont;
        }
        private readonly TraineesDB _context;

     

        // GET: Courses
        public ActionResult Index()
        {
            return View(CourseRepo.GetAll());
        }

        // GET: Courses/Details/5
        public ActionResult Details(int id)
        {
            if (id != null)
            {
                Course x = CourseRepo.GetDetails(id);
                if (x != null)
                    return View(x);
            }
            return RedirectToAction("Index");
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            //ViewData["TraineeID"] = new SelectList(_context.Trainees, "ID", "Birthdate");
            ViewBag.TraineeID = TraineeRepo.GetAll();
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Course course)
        {
            if (ModelState.IsValid)
            {

                CourseRepo.Insert(course);
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.TraineeID = TraineeRepo.GetAll();
            return View(CourseRepo.GetDetails(id));
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("ID,Topic,Grade,TraineeID")] Course course)
        {
            if (id != course.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    CourseRepo.UpdateCourse(id, course);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            ViewData["TraineeID"] = new SelectList(_context.Trainees, "ID", "Birthdate", course.TraineeID);
            return View(course);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(CourseRepo.GetDetails(id));

          
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                CourseRepo.DeleteCourse(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.ID == id);
        }
    }
}
