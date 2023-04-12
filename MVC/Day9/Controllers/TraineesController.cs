using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Day9.Models;
using Day9.RepoServices;
using Microsoft.AspNetCore.Http;

namespace Day9.Controllers
{
    public class TraineesController : Controller
    {
        public ITraineeRepository TraineeRepo { get; }
        public ITrackRepository TrackRepo { get; }
        public ICourseRepository CourseRepo { get; }
        public TraineesDB Cont { get; }

        public TraineesController(ITraineeRepository TRepo, ITrackRepository KRepo, ICourseRepository CRepo, TraineesDB cont)
        {
            TraineeRepo = TRepo;
            TrackRepo = KRepo;
            CourseRepo = CRepo;
            Cont = cont;
        }
        private readonly TraineesDB _context;

        // GET: Trainees
        public ActionResult Index()
        {
            
            return View(TraineeRepo.GetAll());
        }

        // GET: Trainees/Details/5
        public ActionResult Details(int id)
        {
            if (id != null)
            {
                Trainee x = TraineeRepo.GetDetails(id);
                if (x != null)
                    return View(x);
            }
            return RedirectToAction("Index");
        }

        // GET: Trainees/Create
        public ActionResult Create()
        {
            ViewBag.TID = TrackRepo.GetAll();
            //ViewBag.CID = CourseRepo.GetAll();
            return View();
          
        }

        // POST: Trainees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainee trainee)
        {
            try
            {
                TraineeRepo.Insert(trainee);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Trainees/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.TID = TrackRepo.GetAll();
            //ViewBag.CID = CourseRepo.GetAll();
            return View(TraineeRepo.GetDetails(id));
        }

        // POST: Trainees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Trainee trainee)
        {
            try
            {
                TraineeRepo.UpdateTrainee(id, trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }

        }

        // GET: Trainees/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(TraineeRepo.GetDetails(id));
        }

        // POST: Trainees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, IFormCollection collection)
        {
            try
            {
                TraineeRepo.DeleteTrainee(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private bool TraineeExists(int id)
        {
            return _context.Trainees.Any(e => e.ID == id);
        }
    }
}
