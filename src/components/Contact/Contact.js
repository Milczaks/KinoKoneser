import React from "react";

function Contact() {
  return (
    <div className="cent">
      <div className="mg font3 center">
        <h2>Kontakt</h2>
      </div>
      <div className="font2 center">E-mail:</div>
      <div className="font center">kino.koneser@gmail.com</div>
      <div className="font2 center">Telefon:</div>
      <div className="font center">(+48) 261 839 559</div>
      <div className="font2 center">Lokalizacja:</div>
      <div className="font center">
        ul. Gen. Sylwestra Kaliskiego 25a, 01-476 Warszawa
      </div>
      <div className="font">
        <iframe
          title="KinoKoneser"
          src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1019.4941216829059!2d20.894183670020546!3d52.25518433654182!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x471ecaf43b62b463%3A0xe307e622f9737019!2sKlub%20Wat!5e0!3m2!1spl!2spl!4v1663180545057!5m2!1spl!2spl"
        ></iframe>
      </div>
    </div>
  );
}

export default Contact;
