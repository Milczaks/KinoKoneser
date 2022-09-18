//import React, { useState, useEffect } from "react";
import API_URL from "../../utilities/Constants";
import { useEffect, useState, useCallback } from "react";

// import { useParams } from "react-router-dom";

// const params = useParams();
// const { orderId } = params;

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

  console.log(loadedMovie4);

  return (
    <div>
      <div className="font3 mg">
        <h2>Start</h2>
      </div>
      <div className="font2">
        <p className="font3 space">POLECANE FILMY</p>
        <p className="center space">
          Na dzień dzisiejszy, polecamy wszystkim naszym gościom
          dwie najpopularniejsze i najchętniej wyszukiwane seanse:
          <br />
          <br />
        </p>
        <div>
          <div className="right-s">
            <p>Nazwa filmu:</p>
            <p className="font3 no-space center important">
              {loadedMovie4.title}
            </p>
            <p>Opis:</p>
            <p className="font center">{loadedMovie4.description}</p>
            <p>Data produkcji:</p>
            <p className="font center">{loadedMovie4.year}</p>
          </div>
          <img
            className="left-s little"
            src={loadedMovie4.posterURL}
            alt={loadedMovie4.title}
          ></img>
          
          <div className="right-s">
            <p>Nazwa filmu:</p>
            <p className="font3 no-space center important">
              {loadedMovie8.title}
            </p>
            <p>Opis:</p>
            <p className="font center">{loadedMovie8.description}</p>
            <p>Data produkcji:</p>
            <p className="font center">{loadedMovie8.year}</p>
          </div>
          <img
            className="left-s little"
            src={loadedMovie8.posterURL}
            alt={loadedMovie8.title}
          ></img>
        </div>
      </div>
    </div>
  );
};

export default Start;
