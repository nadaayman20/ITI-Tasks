using Day9.Models;
using System.Collections.Generic;
using System.Linq;

namespace Day9.RepoServices
{
   

    public class TrackRepoService : ITrackRepository
    {
        public TraineesDB Context { get; set; }
        public TrackRepoService(TraineesDB context)
        {
            Context = context;
        } 

        public List<Track> GetAll()
        {
            return Context.Tracks.ToList();
        }

      
        public void Insert(Track tk)
        {
            Context.Tracks.Add(tk);
            Context.SaveChanges();
        }

        public void UpdateTrack(int id, Track tk)
        {
            Track TrackUpdated = Context.Tracks.Find(id);
            TrackUpdated.Name= tk.Name;
            TrackUpdated.Description= tk.Description;
          
            Context.SaveChanges();
        }
        public void DeleteTrack(int id)
        {
            Context.Remove(Context.Tracks.Find(id));
            Context.SaveChanges();
        }

        public Track GetDetails(int id)
        {
            return Context.Tracks.Find(id);
        }

        //void ITrackRepository.GetDetails(int? id)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
