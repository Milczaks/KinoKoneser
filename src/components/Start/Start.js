//import React, { useState, useEffect } from "react";
import API_URL from "../../utilities/Constants";
import { useEffect, useState, useCallback } from "react";
import { NavLink } from "react-router-dom";

const Start = () => {

  const [loadedMovie4, setLoadedMovie4] = useState([]);
  const [loadedMovie8, setLoadedMovie8] = useState([]);
  const fetchMovie4Handler = useCallback(async () => {
    try {
      const response = await fetch(`${API_URL}/movies/4`);

      if (!response.ok) {
        throw new Error("Nie udało się pobrać kategorii.");
      }

      const responseData = await response.json();
      setLoadedMovie4(responseData);
    } catch (error) {
      alert(error.message);
    }
  }, []);

  useEffect(() => {
    fetchMovie4Handler();
  }, [fetchMovie4Handler]);

  const fetchMovie8Handler = useCallback(async () => {
    try {
      const response = await fetch(`${API_URL}/movies/8`);

      if (!response.ok) {
        throw new Error("Nie udało się pobrać kategorii.");
      }

      const responseData = await response.json();
      setLoadedMovie8(responseData);
    } catch (error) {
      alert(error.message);
    }
  }, []);

  useEffect(() => {
    fetchMovie8Handler();
  }, [fetchMovie8Handler]);

  return (
    <div>
      <div className="font3 mg">
        <h2>Start</h2>
      </div>
      <div className="font2">
        <p className="font3 space">POLECANE FILMY</p>
        <p className="center space">
          Na dzień dzisiejszy, polecamy wszystkim naszym gościom
          najpopularniejsze dwie premiery filmowe:
          <br />
          <br />
        </p>
        <div className="cent font2">
          <div className="right-s">
            <p>Nazwa filmu:</p>
            <NavLink
              to={`/movies/${loadedMovie4.movieId}`}
              className="font3 no-space cent important"
            >
              {loadedMovie4.title}
            </NavLink>
            <p>Opis:</p>
            <p className="font center">{loadedMovie4.description}</p>
            <p>Data produkcji:</p>
            <p className="font center">{loadedMovie4.year}</p>
          </div>
          <NavLink to = {`/movies/${loadedMovie4.movieId}`} className="left-s b">
            <img
              className="s"
              src={loadedMovie4.posterURL}
              alt={loadedMovie4.title}
            ></img>
          </NavLink>
        </div>
        <div className="cent font2">
          <div className="right-s">
            <p>Nazwa filmu:</p> 
            
            <NavLink
              to={`/movies/${loadedMovie8.movieId}`}
              className="font3 no-space cent important"
            >
              {loadedMovie8.title}
            </NavLink>
           
            <p>Opis:</p>
            <p className="font center">{loadedMovie8.description}</p>
            <p>Data produkcji:</p>
            <p className="font center">{loadedMovie8.year}</p>
          </div>

          <NavLink to = {`/movies/${loadedMovie8.movieId}`} className="left-s b">
            <img
              className="s"
              src={loadedMovie8.posterURL}
              alt={loadedMovie8.title}
            ></img>
          </NavLink>
        </div>
      </div>
    </div>
  );
};

export default Start;
