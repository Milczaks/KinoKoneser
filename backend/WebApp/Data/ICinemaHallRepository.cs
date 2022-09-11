using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data
{
    public interface ICinemaHallRepository
    {
        List<CinemaHall> GetAllCinemaHalls();
        CinemaHall GetCinemaHallById(int id);
        bool AddCinemaHall(CinemaHall cinemaHall);
        bool UpdateCinemaHall(CinemaHall cinemaHall);
        bool DeleteCinemaHall(int id);
    }
}
 