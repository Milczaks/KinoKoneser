using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data
{
    public interface IShowingRepository
    {
        List<Showing> GetAllShowings();
        Showing GetShowingById(int id);
        bool AddShowing(Showing showing);
        bool UpdateShowing(Showing showing);
        bool DeleteShowing(int id);
    }
}
