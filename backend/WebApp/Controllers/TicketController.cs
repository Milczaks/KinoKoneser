using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Model;

namespace WebApp.Controllers
{
    [Route("api/tickets")]
    [Tags("Tickets")]
    [ApiController]
    public class TicketController : ControllerBase
    {

        private readonly ITicketRepository ticketRepository;

        public TicketController(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        [HttpGet("all")]
        public List<Ticket> GetAllTickets()
        {
            return ticketRepository.GetAllTicket();
        }

        [HttpGet("{id}")]
        public Ticket GetTicketById(int id)
        {
            return ticketRepository.GeTicketById(id);
        }

        [HttpPost("add")]
        public ActionResult AddTicket(Ticket ticket)
        {
            bool createSuccesful = ticketRepository.AddTicket(ticket);
            if (createSuccesful)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("delete/{id}")]
        public ActionResult DeleteTicket(int id)
        {
            bool deleteSuccesful = ticketRepository.DeleteTicket(id);
            if (deleteSuccesful)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
