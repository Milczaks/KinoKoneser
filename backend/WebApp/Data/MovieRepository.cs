using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Data
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext db;
        private Movie movie;

        public MovieRepository(AppDbContext db)
        {
            this.db = db;
        }
        public bool AddMovie(Movie movie)
        {
            try
            {
                db.movies.Add(movie);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteMovie(int id)
        {
            try
            {
                db.movies.Remove(movie);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Movie> GetAllMovies()
        {
            return db.movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return db.movies.FirstOrDefault(x => x.movieId == id);
        }

        public bool UpdateMovie(Movie movie)
        {
            try
            {
                db.movies.Update(movie);
                return db.SaveChanges() >= 1;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
