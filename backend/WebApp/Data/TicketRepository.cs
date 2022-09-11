using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data
{
    public class TicketRepository : ITicketRepository
    {
        private readonly AppDbContext db;
        private Ticket ticket;

        public TicketRepository(AppDbContext db)
        {
            this.db = db;
        }
        public List<Ticket> GetAllTicket()
        {
            return db.tickets.ToList();
        }

        public Ticket GeTicketById(int id)
        {
            //TODO
            throw new NotImplementedException();
        }

        public bool AddTicket(Ticket ticket)
        {
            try
            {
                db.tickets.Add(ticket);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteTicket(int id)
        {
            try
            {
                db.tickets.Remove(ticket);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
