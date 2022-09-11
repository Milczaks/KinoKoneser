﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Data;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApp.Model.CinemaHall", b =>
                {
                    b.Property<int>("CinemaHallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CinemaHallId"), 1L, 1);

                    b.Property<string>("CinemaHallName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColumnCount")
                        .HasColumnType("int");

                    b.Property<int>("RowCount")
                        .HasColumnType("int");

                    b.HasKey("CinemaHallId");

                    b.ToTable("cinemaHalls");

                    b.HasData(
                        new
                        {
                            CinemaHallId = 1,
                            CinemaHallName = "1",
                            ColumnCount = 10,
                            RowCount = 5
                        },
                        new
                        {
                            CinemaHallId = 2,
                            CinemaHallName = "2",
                            ColumnCount = 10,
                            RowCount = 5
                        });
                });

            modelBuilder.Entity("WebApp.Model.Movie", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("movieId"), 1L, 1);

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("length")
                        .HasColumnType("int");

                    b.Property<string>("posterURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("movieId");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            description = "Anna Sobańska (Małgorzata Kożuchowska) vel „Zołza”, „Królowa”, „Szekspir”. Dotychczasowy bilans życiowy: 1 mąż, 2 dzieci, 36 statuetek, 40 milionów widzów. Liczba osób, które nie widziały jej twórczości filmowej: hmmm – być może 2 lub 3. Liczba bohaterów, których wymyśliła: 186. Liczba dotychczasowych porażek w życiu osobistym i zawodowym: 0 (przynajmniej tak jej się wydaje). Nadchodzące załamania nerwowe: 1 Anna to kobieta sukcesu i… niekwestionowana zołza. Jednym skinieniem kreuje gwiazdy, a drugim je unicestwia. Chce być silna i idealna w każdym obszarze, choć nie widzi, że jej życie jest dalekie od świata, który kreuje na ekranie. Kiedy jednak wydaje jej się, że ma wszystko, życie postanawia utrzeć jej nosa. Co z tego wyniknie? Czy Zołza zapanuje nad własnym życiem?",
                            length = 96,
                            posterURL = "https://www.crew-united.com/Media/Images/1558/1558327/1558327.entity.jpg",
                            title = "Zołza",
                            year = 2022
                        },
                        new
                        {
                            movieId = 2,
                            description = "Światowej sławy podróżnik i poszukiwacz przygód Guliwer zostaje ponownie zaproszony do krainy Liliputów, którą wcześniej ocalił przed wrogą flotą sąsiedniego kraju Blefuscu. Dochodzi jednak do nieporozumienia, bowiem mieszkańcy oczekują, że u ich bram stanie olbrzym wielkości solidnego budynku, który samym swoim wyglądem odstraszy każdego wroga. Nic jednak z tego, bowiem Guliwer jest zwyczajnego wzrostu i niczym się w tym względzie nie różni od pozostałych mieszkańców. Rozczarowany król wtrąca przybysza do lochu. Tymczasem niezwyciężona armada Blefuscu pod komendą jej żądnego podbojów dowódcy przygotowuje kolejną inwazję. Los pokojowej krainy leży teraz w rękach Guliwera, jego dzielnego mysiego kompana i nowo poznanej przyjaciółki. Do pokonania licznej armii wroga potrzebna będzie nie siła, a spryt.",
                            length = 90,
                            posterURL = "https://maxkino.eu/wp-content/uploads/2022/08/8b66f6e70a1ff629f54c79d1d0a13de1.jpeg",
                            title = "Guliwer",
                            year = 2021
                        },
                        new
                        {
                            movieId = 3,
                            description = "Lata 50. Gospodyni domowa mieszkająca z mężem w utopijnej, eksperymentalnej społeczności, zaczyna się niepokoić, że jego pełna przepychu firma może skrywać niepokojące tajemnice.",
                            length = 122,
                            posterURL = "https://fwcdn.pl/fpo/37/84/853784/8027899.3.jpg",
                            title = "Nie matrw się, kochanie",
                            year = 2022
                        },
                        new
                        {
                            movieId = 4,
                            description = "Psychopatyczna morderczyni o wyglądzie dziecka podszywa się pod zaginioną dziewczynkę.",
                            length = 98,
                            posterURL = "https://ftmp.helios.pl/Get/file/mvpstr/25395/1660809618",
                            title = "Sierota. Narodziny zła",
                            year = 2022
                        },
                        new
                        {
                            movieId = 5,
                            description = "Największym marzeniem Tediego jest zostać zaakceptowanym przez kolegów archeologów. Kiedy niechcący niszczy egipski sarkofag, ściąga na siebie i swoich przyjaciół klątwę. Uratowanie Mumii, Jeffa i Belzoniego zapoczątkuje pełną akcji przygodę. Wraz z Sarą przemierzy pół świata, aby odwrócić klątwę Szmaragdowej Tablicy.",
                            length = 90,
                            posterURL = "https://www.filmy-animowane.pl/wp-content/uploads/2022/07/tedi-i-szmaragdowa-tablica-plakat-600x900.jpg",
                            title = "Tedi i szmaragdowa tablica",
                            year = 2022
                        },
                        new
                        {
                            movieId = 6,
                            description = "",
                            length = 104,
                            posterURL = "https://media.multikino.pl/thumbnails/50/rc/NUVBNEU5/eyJ0aHVtYm5haWwiOnsic2l6ZSI6WyIxMDAwMCIsIjEwMDAwIl0sIm1vZGUiOiJpbnNldCJ9fQ==/uploads/images/films_and_events/bilet-do-raju-plakat-online-cut_7849fe162d.jpg",
                            title = "Bilet do raju",
                            year = 2022
                        },
                        new
                        {
                            movieId = 7,
                            description = "Pisarze, wierni i duchowni kościoła Katolickiego, w miejscach objawień i kultu Świętego Michała Archanioła, odkrywają tajemnicę pierwszego pośród Aniołów Światłości. Świadectwo wiary, historia Kościoła, architektura i sztuka w kulturze chrześcijańskiej przybliża widzom niezwykłą postać Archanioła Michała. Dokument pobudza do refleksji nad rzeczywistością świata Aniołów Bożych i eschatologiczną misją, jaką wypełnia ich wódz. Ten wspaniały dokument zabiera nas po największych sanktuariach Świętego Michała Archanioła między innymi: Monte Snat`Angelo – Gargano-Włochy, Mont Saint Michele – Francja, Rzym - Włochy, Santa Maria La Nova – Włochy, Jasna Góra – Polska. Misję Świętego Michała przybliżą nam wspaniali goście: Abp Henryk Hoser, Ks. Marcello Stanzione, Ks. Henri Gesmier, Ks. Dariusz Wilk oraz osoby które doświadczyły obecności Świętego Michała na Ziemi.",
                            length = 90,
                            posterURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZQSy80wTVR8LomPDeT8NTxTZkkfpluxGR_chukTrm0f-u_qHlhAa1CtKIr9YIu5l8_6g&usqp=CAU",
                            title = "Zobacz Anioła",
                            year = 2022
                        },
                        new
                        {
                            movieId = 8,
                            description = "Asterix, Obelix i Panoramix wyruszają do Egiptu, by pomóc architektowi Numernabisowi. Ma on zaledwie trzy miesiące na wybudowanie pałacu dla Kleopatry.",
                            length = 107,
                            posterURL = "https://fwcdn.pl/fpo/08/96/30896/6900390.3.jpg",
                            title = "Asterix i Obelix: Misja Kleopatra",
                            year = 2002
                        });
                });

            modelBuilder.Entity("WebApp.Model.Showing", b =>
                {
                    b.Property<int>("ShowingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowingId"), 1L, 1);

                    b.Property<int>("CinemaHallId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Dubbing")
                        .HasColumnType("bit");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<bool>("Subtitles")
                        .HasColumnType("bit");

                    b.Property<double>("TicketPrice")
                        .HasColumnType("float");

                    b.HasKey("ShowingId");

                    b.HasIndex("CinemaHallId");

                    b.HasIndex("MovieId");

                    b.ToTable("showings");

                    b.HasData(
                        new
                        {
                            ShowingId = 1,
                            CinemaHallId = 1,
                            Date = new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Dubbing = false,
                            MovieId = 2,
                            Subtitles = false,
                            TicketPrice = 20.0
                        },
                        new
                        {
                            ShowingId = 2,
                            CinemaHallId = 1,
                            Date = new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            Dubbing = false,
                            MovieId = 2,
                            Subtitles = false,
                            TicketPrice = 20.0
                        });
                });

            modelBuilder.Entity("WebApp.Model.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"), 1L, 1);

                    b.Property<int>("CinemaHallId")
                        .HasColumnType("int");

                    b.Property<int>("ColumnNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<int>("ShowingId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("ShowingId");

                    b.ToTable("tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            CinemaHallId = 0,
                            ColumnNumber = 2,
                            PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RowNumber = 3,
                            ShowingId = 1
                        },
                        new
                        {
                            TicketId = 2,
                            CinemaHallId = 0,
                            ColumnNumber = 1,
                            PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RowNumber = 2,
                            ShowingId = 2
                        },
                        new
                        {
                            TicketId = 3,
                            CinemaHallId = 0,
                            ColumnNumber = 6,
                            PurchaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RowNumber = 2,
                            ShowingId = 1
                        });
                });

            modelBuilder.Entity("WebApp.Model.Showing", b =>
                {
                    b.HasOne("WebApp.Model.CinemaHall", "CinemaHall")
                        .WithMany("Showings")
                        .HasForeignKey("CinemaHallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Model.Movie", "Movie")
                        .WithMany("Showings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaHall");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("WebApp.Model.Ticket", b =>
                {
                    b.HasOne("WebApp.Model.Showing", "Showing")
                        .WithMany("Tickets")
                        .HasForeignKey("ShowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Showing");
                });

            modelBuilder.Entity("WebApp.Model.CinemaHall", b =>
                {
                    b.Navigation("Showings");
                });

            modelBuilder.Entity("WebApp.Model.Movie", b =>
                {
                    b.Navigation("Showings");
                });

            modelBuilder.Entity("WebApp.Model.Showing", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
