import React from "react";
import API_URL from "../../utilities/Constants";
import { useEffect, useState, useCallback } from "react";

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

  console.log(loadedMovies);

  return (
    <div className="font3 mg">
      <h2>Repertuar</h2>
      <p className="font center">
        W naszym kinie cenimy dobre gusta naszyk klientów oraz dbamy o nich
        podczas doboru repertuaru.
      </p>
      <p className="font center">U nas zobaczysz takie wspaniałe filmy, jak:</p>
      <div className="cent">
        <div className="font2">
          <div className="right-s">
            <p>Nazwa filmu:</p>
            <p className="font3 no-space center important">
              {loadedMovies.title}
            </p>
            <p>Data produkcji:</p>
            <p className="font center">{loadedMovies.year}</p>
          </div>
          <img
            className="left-s little"
            src={loadedMovies.posterURL}
            alt={loadedMovies.title}
          ></img>
        </div>
      </div>

      <div className="cent">
        <div className="font2">
          <div className="right-s">
            <p>Nazwa filmu:</p>
            <p className="font3 no-space center important">
              {loadedMovies.title}
            </p>
            <p>Data produkcji:</p>
            <p className="font center">{loadedMovies.year}</p>
          </div>
          <img
            className="left-s little"
            src={loadedMovies.posterURL}
            alt={loadedMovies.title}
          ></img>
        </div>
      </div>
    </div>
    


    
  );
}

export default Repo;
