import React from "react";
import API_URL from "../../utilities/Constants";
import { useEffect, useState, useCallback } from "react";
import { NavLink } from "react-router-dom";

function Repo() {
  const [loadedMovies, setLoadedMovies] = useState([]);
  const fetchMovieHandler = useCallback(async () => {
    try {
      const response = await fetch(`${API_URL}/movies/all`);

      if (!response.ok) {
        throw new Error("Nie udało się pobrać kategorii.");
      }

      const responseData = await response.json();
      setLoadedMovies(responseData);
    } catch (error) {
      alert(error.message);
    }
  }, []);

  useEffect(() => {
    fetchMovieHandler();
  }, [fetchMovieHandler]);

  return (
    <div className="font3 mg">
      <h2>Repertuar</h2>
      <p className="font center">
        W naszym kinie cenimy dobre gusta naszyk klientów oraz dbamy o nich
        podczas doboru repertuaru.
      </p>
      <p className="font center">U nas zobaczysz takie wspaniałe filmy, jak:</p>
      {loadedMovies.map((movie) => (
        <div className="cent font2" key={movie.movieId}>
          <div className="right-s">
            <p>Nazwa filmu:</p>
            <NavLink
              to={`/movies/${movie.movieId}`}
              className="font3 no-space center important"
            >
              {movie.title}
            </NavLink>
            <p>Data produkcji:</p>
            <p className="font center">{movie.year}</p>
          </div>
          <NavLink to={`/movies/${movie.movieId}`} className="left-s b">
            <img className="s" src={movie.posterURL} alt={movie.title}></img>
          </NavLink>
        </div>
      ))}
      ;
    </div>
  );
}

export default Repo;
