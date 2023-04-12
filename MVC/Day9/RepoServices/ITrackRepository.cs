using Day9.Models;
using System.Collections.Generic;

namespace Day9.RepoServices
{
    public interface ITrackRepository
    {
        public List<Track> GetAll();
        public Track GetDetails(int id);
        public void Insert(Track tk);
        public void UpdateTrack(int id, Track tk);
        public void DeleteTrack(int id);
    }
}
