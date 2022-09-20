import React from "react";
import { NavLink } from "react-router-dom";

function Booked(props) {

  return props.trigger ? (
    <div className="popup">
      <div className="popup-inner">
        <NavLink to="/" onClick={() => props.setTrigger(false)}>
          <button className="close-btn" >X</button>
        </NavLink>
        <h3 className="font3 important">Rezerwacja przebiegła pomyślnie!</h3>
        <div>
          <h3 className="space">Twój bilet został poprawnie zarezerwowany!</h3>
          <h3 className="space">Po odbiór biletu zapraszamy do kasy w naszym kinie.</h3>
          <h3 className="space">Zmiana rezerwacji możliwa jest telefonicznie na naszej infoliini.</h3>
          <h3 className="space"> Zapraszamy na film i życzymy miłego seansu! </h3>
      </div>
    </div>
    </div>
  ) : (
    ""
  );
}
export default Booked;
