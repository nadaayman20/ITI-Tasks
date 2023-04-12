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
    public class TracksController : Controller
    {
        public ITraineeRepository TraineeRepo { get; }
        public ITrackRepository TrackRepo { get; }
        public ICourseRepository CourseRepo { get; }
        public TraineesDB Cont { get; }

        public TracksController(ITraineeRepository TRepo, ITrackRepository KRepo, ICourseRepository CRepo, TraineesDB cont)
        {
            TraineeRepo = TRepo;
            TrackRepo = KRepo;
            CourseRepo = CRepo;
            Cont = cont;
        }
        private readonly TraineesDB _context;


        // GET: Tracks
        public ActionResult Index()
        {
            if(TrackRepo.GetAll() !=null)
            {
                return View(TrackRepo.GetAll());
            }
            return View();
        }

        // GET: Tracks/Details/5
        public ActionResult Details(int id)
        {
            if(id != null)
            {
                Track x = TrackRepo.GetDetails(id);
                if (x != null)
                    return View(x);
            }
            return RedirectToAction("Index");
        }

        // GET: Tracks/Create
        public ActionResult Create()
        {     
            return View();
        }

        // POST: Tracks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ID,Name,Description")] Track track)
        {
            if (ModelState.IsValid)
            {

                TrackRepo.Insert(track);
                return RedirectToAction(nameof(Index));
            }
            return View(track);
        }

        // GET: Tracks/Edit/5
        public ActionResult Edit(int id)
        {
            return View(TrackRepo.GetDetails(id));
        }

        // POST: Tracks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("ID,Name,Description")] Track track)
        {
            try
            {
                TrackRepo.UpdateTrack(id, track);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tracks/Delete/5
        public ActionResult Delete(int id)
        {
            return View(TrackRepo.GetDetails(id));
        }

        // POST: Tracks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                TrackRepo.DeleteTrack(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private bool TrackExists(int id)
        {
            return _context.Tracks.Any(e => e.ID == id);
        }
    }
}
