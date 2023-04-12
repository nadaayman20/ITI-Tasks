using Day9.Models;
using System.Collections.Generic;

namespace Day9.RepoServices
{
    public interface ITraineeRepository
    {
        public List<Trainee> GetAll();
        public Trainee GetDetails(int id);
        public void Insert(Trainee trn);
        public void UpdateTrainee(int id, Trainee trn);
        public void DeleteTrainee(int id);
    }
}
