using Day9.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Day9.RepoServices
{
    public class TraineeRepoService : ITraineeRepository
    {
        public TraineesDB Context { get; set; }
        public TraineeRepoService(TraineesDB context)
        {
            Context = context;
        }

        public List<Trainee> GetAll()
        {
           return Context.Trainees.Include(t =>t.Track).ToList();
        }

        //public Trainee GetDetails(int id)
        //{
        //    return Context.Trainees.FirstOrDefault(tr => tr.ID ==id);
        //}

        public void Insert(Trainee trn)
        {
            Context.Trainees.Add(trn);
            Context.SaveChanges();
        }

        public void UpdateTrainee(int id, Trainee trn)
        {
            Trainee TraineeUpdated = Context.Trainees.Find(id);
            TraineeUpdated.Name = trn.Name;
            TraineeUpdated.gender = trn.gender;
            TraineeUpdated.Email = trn.Email;
            TraineeUpdated.Mobile = trn.Mobile;
            TraineeUpdated.Birthdate = trn.Birthdate;
            TraineeUpdated.TrackID= trn.TrackID;


            Context.SaveChanges();
        }
        public void DeleteTrainee(int id)
        {
            Context.Remove(Context.Trainees.Find(id));
            Context.SaveChanges();
        }
        public Trainee GetDetails(int id)
        {
            return Context.Trainees.Find(id);
        }

    }
}
