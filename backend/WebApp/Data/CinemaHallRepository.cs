using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data
{
    public class CinemaHallRepository : ICinemaHallRepository
    {
        private readonly AppDbContext db;
        private CinemaHall cinemaH;

        public CinemaHallRepository(AppDbContext db)
        {
            this.db = db;
        }
        public bool AddCinemaHall(CinemaHall cinemaHall)
        {
            try
            {
                db.cinemaHalls.Add(cinemaHall);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteCinemaHall(int id)
        {
            try
            {
                db.cinemaHalls.Remove(cinemaH);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<CinemaHall> GetAllCinemaHalls()
        {
            return db.cinemaHalls.ToList();
        }

        public CinemaHall GetCinemaHallById(int id)
        {
            return db.cinemaHalls.FirstOrDefault(x => x.CinemaHallId == id);
        }

        public bool UpdateCinemaHall(CinemaHall cinemaHall)
        {
            try
            {
                db.cinemaHalls.Update(cinemaHall);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
