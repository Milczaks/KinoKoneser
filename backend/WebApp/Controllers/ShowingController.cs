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
    [Route("api/showings")]
    [Tags("Showings")]
    [ApiController]
    public class ShowingController : ControllerBase
    {
        private readonly IShowingRepository showingRepository;

        public ShowingController(IShowingRepository showingRepository)
        {
            this.showingRepository = showingRepository;
        }

        [HttpGet("all")]
        public List<Showing> GetAllShowings()
        {
            return showingRepository.GetAllShowings();
        }

        [HttpGet("{id}")]
        public Showing GetShowingById(int id)
        {
            return showingRepository.GetShowingById(id);
        }

        [HttpPost("add")]
        public ActionResult AddShowing(Showing showing)
        {
            bool createSuccesful = showingRepository.AddShowing(showing);
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
        public ActionResult DeleteShowing(int id)
        {
            bool deleteSuccesful = showingRepository.DeleteShowing(id);
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
        public ActionResult UpdateShowing(Showing showing)
        {
            bool updateSuccesful = showingRepository.UpdateShowing(showing);
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
