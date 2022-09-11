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
    [Route("api/movies")]
    [Tags("Movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        [HttpGet("all")]
        public List<Movie> GetAllMovies()
        {
            return movieRepository.GetAllMovies();
        }

        [HttpGet("{id}")]
        public Movie GetMovieById(int id)
        {
            return movieRepository.GetMovieById(id);
        }

        [HttpPost("add")]
        public ActionResult AddMovie(Movie movie)
        {
            bool createSuccesful = movieRepository.AddMovie(movie);
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
        public ActionResult DeleteMovie(int id)
        {
            bool deleteSuccesful = movieRepository.DeleteMovie(id);
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
        public ActionResult UpdateMovie(Movie movie)
        {
            bool updateSuccesful = movieRepository.UpdateMovie(movie);
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
