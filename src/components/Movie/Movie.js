import React from "react";
import { useParams, NavLink } from "react-router-dom";
import API_URL from "../../utilities/Constants";
import { useEffect, useState, useCallback } from "react";

function Movie() {
  const { ID } = useParams();
  console.log(ID);

  const [loadedMovies, setLoadedMovies] = useState([]);
  const fetchMovieHandler = useCallback(async () => {
    try {
      const response = await fetch(`${API_URL}/movies/${ID}`);

      if (!response.ok) {
        throw new Error("Nie udało się pobrać filmu.");
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

  const [loadedShowing, setLoadedShowing] = useState([]);
  const fetchShowingHandler = useCallback(async () => {
    try {
      const response = await fetch(`${API_URL}/showings/${ID}`);

      if (!response.ok) {
        throw new Error("Nie udało się pobrać filmu.");
      }

      const responseData = await response.json();
      setLoadedShowing(responseData);
    } catch (error) {
      alert(error.message);
    }
  }, []);

  useEffect(() => {
    fetchShowingHandler();
  }, [fetchShowingHandler]);

  return (
    <div className="font3 mg">
      <div className="cent font2">
        <div className="right-s">
          <p>Nazwa filmu:</p>
          <NavLink
            to={`/movies/${loadedMovies.movieId}`}
            className="font3 no-space cent important"
          >
            {loadedMovies.title}
          </NavLink>
          <p>Opis:</p>
          <p className="font center">{loadedMovies.description}</p>
          <p>Data produkcji:</p>
          <p className="font center">{loadedMovies.year}</p>
        </div>
        <NavLink to={`/movies/${loadedMovies.movieId}`} className="left-s b">
          <img
            className="s"
            src={loadedMovies.posterURL}
            alt={loadedMovies.title}
          ></img>
        </NavLink>
      </div>

      <div className="font2 mg">
        {loadedShowing.map((showing) => (
          <div className="right-s" key={showing.showingId}>
            <div className="left-t">
              <p>Data: </p>
              <p className="ticket-p1">{showing.date}</p>
            </div>
            <div className="center-t">
              <p>Cena biletu: </p>
              <p className="ticket-p1">{showing.ticketPrice}zł</p>
            </div>
            <div className="right-t">
              <p>Numer sali: </p>
              <p className="ticket-p1">{showing.cinemaHallId}</p>
            </div>
            <div><button className="bt">Rezerwuj</button></div>
          </div>
        ))}
      </div>
    </div>
  );
}

export default Movie;
