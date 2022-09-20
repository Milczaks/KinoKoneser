import React from "react";
//import GooglePayButton from "@google-pay/button-react";
//import { NavItem } from "react-bootstrap"
import { useState } from "react";

function Booking(props) {
  const [message, setMessage] = useState("");

  const handleChange = (event) => {
    setMessage(event.target.value);
  };

  return props.trigger ? (
    <div className="popup">
      <div className="popup-inner">
        <button className="close-btn" onClick={() => props.setTrigger(false)}>
          X
        </button>
        <h3>Rezerwacja</h3>
        <div className="left l">
          <p>Uzupełnij formularz z danymi do biletu.</p>
          <p>Imię:</p>
          <p>
            <input type="text" id="name" size="16"></input>
          </p>
          <p>Nazwisko:</p>{" "}
          <p>
            <input type="text" id="surname" size="16"></input>
          </p>
          <p>Numer telefonu:</p>
          <p>
            <input type="tel" id="tel" size="16"></input>
          </p>
        </div>
        <div className="right">
          <p>Wybierz ile miejsc chcesz zarezerwować:</p>
          <p className="important">
            'Uwaga, w naszym kinie miejsca są niespodziankami! Jeśli chcesz
            miejsce obok kolegi, przy odbiorze musisz to zaznaczć. Kto pierwszy
            ten lepszy!'
          </p>

          <p>
            <input
              type="number"
              id="message"
              name="message"
              onChange={handleChange}
              value={message}
              size="16"
              max={50}
              min={0}
            ></input>
          </p>

          <p class="text">
            Kwota za każde miejsce wynosi <span>20</span>zł. Musisz zapłacić:{" "}
            {message * 20}zł.
          </p>
        </div>
        
        {/* <div><button className="close-btn" onClick={() => props.setTrigger(false)}>Zapłać</button></div> */}
      </div>
    </div>
  ) : (
    ""
  );
}
export default Booking;
