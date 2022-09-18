//import React, { useState, useEffect } from "react";
import API_URL from '../../utilities/Constants';
import { useEffect, useState, useCallback } from 'react'


const Start = () => {
  // const [showings, setShowings] = useState([]);

  // useEffect(() => {
  //   fetch("/api/showings/all").then((res) => console.log(res));
  // }, []);


  const [loadedMovies, setLoadedMovies] = useState([]);
  const fetchMovieHandler = useCallback(async () => {
    try {
      const response = await fetch(`${API_URL}/movies/all`);
      
      if (!response.ok) {
        throw new Error('Nie udało się pobrać kategorii.');
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

  console.log(loadedMovies)


  return (
    <div>
      <div className="font3 mg">
        <h2>Start</h2>
      </div>
      <div className="font2">
        <p className="font3 space">POLECANE FILMY</p>
        <p className="center space">
          Na dzień dzisiejszy, polecamy wszystkim naszym gościom najnowsze
          premiery filmowe:
        </p>

        
      </div>
    </div>
  );
};

export default Start;
