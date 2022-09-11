using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data
{
    public class ShowingRepository : IShowingRepository
    {
        private readonly AppDbContext db;
        private Showing showing;

        public ShowingRepository(AppDbContext db)
        {
            this.db = db;
        }
        public bool AddShowing(Showing showing)
        {
            try
            {
                db.showings.Add(showing);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteShowing(int id)
        {
            try
            {
                db.showings.Remove(showing);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Showing> GetAllShowings()
        {
            return db.showings.ToList();
        }

        public Showing GetShowingById(int id)
        {
            return db.showings.FirstOrDefault(x => x.ShowingId == id);
        }

        public bool UpdateShowing(Showing showing)
        {
            try
            {
                db.showings.Update(showing);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
