import React from "react";
//import kinoKoneser from "./images/kinoKoneser.png";
import { BrowserRouter, Route, Routes } from "react-router-dom";

import Start from "./Start/Start";
import About from "./About/About";
import Contact from "./Contact/Contact";
import Repo from "./Repo/Repo";
import Navbar from "./Navbar.js";
//import Footer from "./Footer";

//<img src={kinoKoneser} alt="logo" />
function App() {
  return (
    <><BrowserRouter>
      <Navbar />
      <div className="App">
        <header className="App-header">
          <Routes>
            <Route path="/" element={<Start />} />
            <Route path="/about" element={<About />} />
            <Route path="/kontakt" element={<Contact />} />
            <Route path="/repertuar" element={<Repo />} />
          </Routes>
        </header>
      </div>

    </BrowserRouter>
    <footer className="foot">
        &copy; Milena Grzyb <br />
        Wojskowa Akademia Techniczna 2022
    </footer></>
 );

}

/*
<BrowserRouter>
  <Routes>
    <Route path="/start">
      <Start />
    </Route>
  </Routes>
</BrowserRouter>;
*/

export default App;
