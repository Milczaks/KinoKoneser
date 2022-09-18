import React from "react";
//import Logo from "./Logo.js";

function About() {
  return (
    <div>
      <div className="font3 mg">
        <h2>O nas</h2>
      </div>
      <div className="left">
        <img src="https://docplayer.pl/docs-images/108/183275596/images/11-5.jpg" alt="Kino" />
      </div>
      <div className="right">
        <div className="menu-sections flex">
          <div>
            <a href="#informacje" className="mininav font1 ">
              INFORMACJE
            </a>
          </div>
          <div>
            <a href="#oferta" className="font1 mininav">
              OFERTA
            </a>
          </div>
          <div>
            <a href="#godziny" className="font1 mininav">
              GODZINY
            </a>
          </div>
          <div>
            <a href="#dojazd" className="font1 mininav">
              DOJAZD
            </a>
          </div>
        </div>
        <section id="informacje" className="font2">
          <p className="font3">INFORMACJE</p>
          <p className="no-space">
            Kino Koneser jest zlokalizowane przy Wojskowej Akademii Technicznej,
            dokładniej w Klubie WAT. Posiada kilka klimatycznych sal
            wypozażonych w najwyższej klasy sprzęt nagłaśniającym a także
            perłowe okrany Harkness. Oprócz premier kinowych, zajmujemy się
            ogranizacją imprez okolicznościowych, takich jak:
          </p>
          <p className="no-space">♦ Walentynki</p>
          <p className="no-space">♦ Ferie</p>
          <p className="no-space">♦ Dzień dziecka</p>
          <p className="no-space">i spotkania okolicznościowe.</p>
          <p>
            Niepowtarzalna atmosfera i klimat panujący w sieci naszych kin
            sprawia, że okoliczni mieszkańcy z chęcią odwiedzają nasze placówki.
          </p>
        </section>

        <section id="oferta" className="font2">
          <p className="font3 space">OFERTA</p>
          <p>Kino Koneser to poza standardowymi seansami filmowymi również:</p>
          <p className="no-space">
            ♦ specjalne, przedpremierowe pokazy filmów (z udziałem twórców),
            <p className="no-space">♦ maratony filmowe, </p>
            <p className="no-space">♦ gry i zabawy dla dzieci,</p>
            <p className="no-space">♦ konkursy, </p>
            <p className="no-space">♦ seanse dla grup szkolnych i firm.</p>
            <p>
              Kino Koneser to również idealne miejsce do przeprowadzania
              nietypowych akcji marketingowych. Nasza oferta skierowana jest do
              dużych i średnich przedsiębiorstw pragnących skutecznie i w
              atrakcyjny sposób dotrzeć do swoich klientów poprzez działania
              BTL. Ze względu na niskie koszty jest to również bardzo atrakcyjna
              oferta dla mniejszych, lokalnych firm pragnących przedstawić swoje
              produkty i usługi.
            </p>
            <p>Proponujemy Państwu współpracę w zakresie:</p>
            <p className="no-space">
              zakupu biletów dla pracowników po niższych cenach, zorganizowania
              specjalnego seansu filmowego dla Państwa pracowników bądź
              klientów, zorganizowania imprezy okolicznościowej połączonej z
              projekcją filmu np. z okazji Gwiazdki, Dnia Dziecka itp.,
            </p>
            <p className="no-space">
              umożliwiamy również dotarcie do Państwa klientów poprzez emisje
              reklam na naszych ekranach przed seansami filmowymi,
              przeprowadzania w holu kina akcji promocyjnej (dystrybucja ulotek,
              folderów, próbek, itp.), nadruk Państwa reklamy na rewersie
              biletów kinowych, uczestnictwo w premierach filmowych na zasadach
              sponsoringu.
            </p>
          </p>
        </section>

        <section id="godziny" className="font2">
          <p className="font3 space">GODZINY</p>
          <p>Kino Koneser zaprasza codziennie:</p>
          <p className="no-space"> • Poniedziałek: 9-21</p>
          <p className="no-space"> • Wtorek: 9-22</p>
          <p className="no-space"> • Środa: 9-22</p>
          <p className="no-space"> • Czwartek: 9-22</p>
          <p className="no-space"> • Piątek: 9-23</p>
          <p className="no-space"> • Sobota: 8-22</p>
          <p className="no-space"> • Niedziela: 9-20</p>
          <p className="no-space important">Uwaga!</p>
          <p className="no-space important">
            W święta Kino Koneser jest czynne w godzinach: 8-12
          </p>
        </section>

        <section id="dojazd" className="font2">
          <p className="font3 space">DOJAZD</p>
          <div>
            <div>autobus:</div>
            <div>linie:220 i 167 na przystanek Archimedesa 02</div>
          </div>
          <div>
            <div>tramwaj:</div>
            <div>liniea 20 na przystanek Archimedesa 02</div>
          </div>
          <div>
            <div>samochód:</div>
            <div>
              <p className="no-space">
                możliwość zaparkowania w okolicy Kina Koneser
              </p>
              <p className="no-space">
                (miejsca na zasadzia "kto pierwszy ten lepszy")
              </p>
            </div>
          </div>
        </section>
      </div>
    </div>
  );
}

export default About;
