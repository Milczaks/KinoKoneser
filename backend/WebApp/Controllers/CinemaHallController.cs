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
    [Route("api/cinemaHalls")]
    [Tags("Cinema Halls")]
    [ApiController]
    public class CinemaHallController : ControllerBase
    {
        private readonly ICinemaHallRepository cinemaHallRepository;

        public CinemaHallController(ICinemaHallRepository cinemaHallRepository)
        {
            this.cinemaHallRepository = cinemaHallRepository;
        }

        [HttpGet("all")]
        public List<CinemaHall> GetAllCinemaHalls()
        {
            return cinemaHallRepository.GetAllCinemaHalls();
        }

        [HttpGet("{id}")]
        public CinemaHall GetCinemaHall(int id)
        {
            return cinemaHallRepository.GetCinemaHallById(id);
        }

        [HttpPost("add")]
        public ActionResult AddCinemaHall(CinemaHall cinemaHall)
        {
            bool createSuccesful = cinemaHallRepository.AddCinemaHall(cinemaHall);
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
        public ActionResult DeleteCinemaHall(int id)
        {
            bool deleteSuccesful = cinemaHallRepository.DeleteCinemaHall(id);
            if (deleteSuccesful)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("update")]
        public ActionResult UpdateCinemaHall(CinemaHall cinemaHall)
        {
            bool updateSuccesful = cinemaHallRepository.UpdateCinemaHall(cinemaHall);
            if (updateSuccesful)
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
