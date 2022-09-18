import { NavLink } from "react-router-dom";

//import KK from "../images/KK.png";
//<img src={KK} alt="logo" />

const Navbar = () => (
  <nav className="nav">
    <NavLink to="/" className="nav-item logo" >
      KINO Koneser
    </NavLink>
    <NavLink to="/" className="nav-item" >
      Start
    </NavLink>
    <NavLink to="/about" className="nav-item" >
      O nas
    </NavLink>
    <NavLink to="/repertuar" className="nav-item" >
      Repertuar
    </NavLink>
    <NavLink to="/kontakt" className="nav-item" >
      Kontakt
    </NavLink>
  </nav>
);

export default Navbar;
