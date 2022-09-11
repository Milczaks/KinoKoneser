using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class dane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropColumn(
                name: "QRString",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "QRStringImage",
                table: "tickets");

            migrationBuilder.AddColumn<int>(
                name: "CinemaHallId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColumnNumber",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RowNumber",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShowingId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "cinemaHalls",
                columns: new[] { "CinemaHallId", "CinemaHallName", "ColumnCount", "RowCount" },
                values: new object[,]
                {
                    { 1, "1", 10, 5 },
                    { 2, "2", 10, 5 }
                });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 1,
                columns: new[] { "description", "length", "posterURL", "title" },
                values: new object[] { "Anna Sobańska (Małgorzata Kożuchowska) vel „Zołza”, „Królowa”, „Szekspir”. Dotychczasowy bilans życiowy: 1 mąż, 2 dzieci, 36 statuetek, 40 milionów widzów. Liczba osób, które nie widziały jej twórczości filmowej: hmmm – być może 2 lub 3. Liczba bohaterów, których wymyśliła: 186. Liczba dotychczasowych porażek w życiu osobistym i zawodowym: 0 (przynajmniej tak jej się wydaje). Nadchodzące załamania nerwowe: 1 Anna to kobieta sukcesu i… niekwestionowana zołza. Jednym skinieniem kreuje gwiazdy, a drugim je unicestwia. Chce być silna i idealna w każdym obszarze, choć nie widzi, że jej życie jest dalekie od świata, który kreuje na ekranie. Kiedy jednak wydaje jej się, że ma wszystko, życie postanawia utrzeć jej nosa. Co z tego wyniknie? Czy Zołza zapanuje nad własnym życiem?", 96, "https://www.crew-united.com/Media/Images/1558/1558327/1558327.entity.jpg", "Zołza" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movieId", "description", "length", "posterURL", "title", "year" },
                values: new object[,]
                {
                    { 2, "Światowej sławy podróżnik i poszukiwacz przygód Guliwer zostaje ponownie zaproszony do krainy Liliputów, którą wcześniej ocalił przed wrogą flotą sąsiedniego kraju Blefuscu. Dochodzi jednak do nieporozumienia, bowiem mieszkańcy oczekują, że u ich bram stanie olbrzym wielkości solidnego budynku, który samym swoim wyglądem odstraszy każdego wroga. Nic jednak z tego, bowiem Guliwer jest zwyczajnego wzrostu i niczym się w tym względzie nie różni od pozostałych mieszkańców. Rozczarowany król wtrąca przybysza do lochu. Tymczasem niezwyciężona armada Blefuscu pod komendą jej żądnego podbojów dowódcy przygotowuje kolejną inwazję. Los pokojowej krainy leży teraz w rękach Guliwera, jego dzielnego mysiego kompana i nowo poznanej przyjaciółki. Do pokonania licznej armii wroga potrzebna będzie nie siła, a spryt.", 90, "https://maxkino.eu/wp-content/uploads/2022/08/8b66f6e70a1ff629f54c79d1d0a13de1.jpeg", "Guliwer", 2021 },
                    { 3, "Lata 50. Gospodyni domowa mieszkająca z mężem w utopijnej, eksperymentalnej społeczności, zaczyna się niepokoić, że jego pełna przepychu firma może skrywać niepokojące tajemnice.", 122, "https://fwcdn.pl/fpo/37/84/853784/8027899.3.jpg", "Nie matrw się, kochanie", 2022 },
                    { 4, "Psychopatyczna morderczyni o wyglądzie dziecka podszywa się pod zaginioną dziewczynkę.", 98, "https://ftmp.helios.pl/Get/file/mvpstr/25395/1660809618", "Sierota. Narodziny zła", 2022 },
                    { 5, "Największym marzeniem Tediego jest zostać zaakceptowanym przez kolegów archeologów. Kiedy niechcący niszczy egipski sarkofag, ściąga na siebie i swoich przyjaciół klątwę. Uratowanie Mumii, Jeffa i Belzoniego zapoczątkuje pełną akcji przygodę. Wraz z Sarą przemierzy pół świata, aby odwrócić klątwę Szmaragdowej Tablicy.", 90, "https://www.filmy-animowane.pl/wp-content/uploads/2022/07/tedi-i-szmaragdowa-tablica-plakat-600x900.jpg", "Tedi i szmaragdowa tablica", 2022 },
                    { 6, "", 104, "https://media.multikino.pl/thumbnails/50/rc/NUVBNEU5/eyJ0aHVtYm5haWwiOnsic2l6ZSI6WyIxMDAwMCIsIjEwMDAwIl0sIm1vZGUiOiJpbnNldCJ9fQ==/uploads/images/films_and_events/bilet-do-raju-plakat-online-cut_7849fe162d.jpg", "Bilet do raju", 2022 },
                    { 7, "Pisarze, wierni i duchowni kościoła Katolickiego, w miejscach objawień i kultu Świętego Michała Archanioła, odkrywają tajemnicę pierwszego pośród Aniołów Światłości. Świadectwo wiary, historia Kościoła, architektura i sztuka w kulturze chrześcijańskiej przybliża widzom niezwykłą postać Archanioła Michała. Dokument pobudza do refleksji nad rzeczywistością świata Aniołów Bożych i eschatologiczną misją, jaką wypełnia ich wódz. Ten wspaniały dokument zabiera nas po największych sanktuariach Świętego Michała Archanioła między innymi: Monte Snat`Angelo – Gargano-Włochy, Mont Saint Michele – Francja, Rzym - Włochy, Santa Maria La Nova – Włochy, Jasna Góra – Polska. Misję Świętego Michała przybliżą nam wspaniali goście: Abp Henryk Hoser, Ks. Marcello Stanzione, Ks. Henri Gesmier, Ks. Dariusz Wilk oraz osoby które doświadczyły obecności Świętego Michała na Ziemi.", 90, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZQSy80wTVR8LomPDeT8NTxTZkkfpluxGR_chukTrm0f-u_qHlhAa1CtKIr9YIu5l8_6g&usqp=CAU", "Zobacz Anioła", 2022 },
                    { 8, "Asterix, Obelix i Panoramix wyruszają do Egiptu, by pomóc architektowi Numernabisowi. Ma on zaledwie trzy miesiące na wybudowanie pałacu dla Kleopatry.", 107, "https://fwcdn.pl/fpo/08/96/30896/6900390.3.jpg", "Asterix i Obelix: Misja Kleopatra", 2002 }
                });

            migrationBuilder.InsertData(
                table: "showings",
                columns: new[] { "ShowingId", "CinemaHallId", "Date", "Dubbing", "MovieId", "Subtitles", "TicketPrice" },
                values: new object[] { 1, 1, new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), false, 2, false, 20.0 });

            migrationBuilder.InsertData(
                table: "showings",
                columns: new[] { "ShowingId", "CinemaHallId", "Date", "Dubbing", "MovieId", "Subtitles", "TicketPrice" },
                values: new object[] { 2, 1, new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), false, 2, false, 20.0 });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "TicketId", "CinemaHallId", "ColumnNumber", "PurchaseDate", "RowNumber", "ShowingId" },
                values: new object[] { 1, 0, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "TicketId", "CinemaHallId", "ColumnNumber", "PurchaseDate", "RowNumber", "ShowingId" },
                values: new object[] { 2, 0, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.InsertData(
                table: "tickets",
                columns: new[] { "TicketId", "CinemaHallId", "ColumnNumber", "PurchaseDate", "RowNumber", "ShowingId" },
                values: new object[] { 3, 0, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_tickets_ShowingId",
                table: "tickets",
                column: "ShowingId");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_showings_ShowingId",
                table: "tickets",
                column: "ShowingId",
                principalTable: "showings",
                principalColumn: "ShowingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tickets_showings_ShowingId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_ShowingId",
                table: "tickets");

            migrationBuilder.DeleteData(
                table: "cinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tickets",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "showings",
                keyColumn: "ShowingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "showings",
                keyColumn: "ShowingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "cinemaHalls",
                keyColumn: "CinemaHallId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CinemaHallId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "ColumnNumber",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "RowNumber",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "ShowingId",
                table: "tickets");

            migrationBuilder.AddColumn<string>(
                name: "QRString",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QRStringImage",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowingId = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    ColumnNumber = table.Column<int>(type: "int", nullable: false),
                    ReservationExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_reservations_showings_ShowingId",
                        column: x => x.ShowingId,
                        principalTable: "showings",
                        principalColumn: "ShowingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservations_tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "movieId",
                keyValue: 1,
                columns: new[] { "description", "length", "posterURL", "title" },
                values: new object[] { "AA", 150, "https://i.etsystatic.com/22295500/r/il/bd145e/2433214065/il_794xN.2433214065_q359.jpg", "AAA" });

            migrationBuilder.CreateIndex(
                name: "IX_reservations_ShowingId",
                table: "reservations",
                column: "ShowingId");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_TicketId",
                table: "reservations",
                column: "TicketId");
        }
    }
}
