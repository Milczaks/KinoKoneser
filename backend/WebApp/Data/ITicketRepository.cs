using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data
{
    public interface ITicketRepository
    {
        List<Ticket> GetAllTicket();
        Ticket GeTicketById(int id);
        bool AddTicket(Ticket ticket);
        bool DeleteTicket(int id);
    }
}
