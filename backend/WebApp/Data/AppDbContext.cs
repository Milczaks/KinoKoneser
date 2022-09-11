using Microsoft.EntityFrameworkCore;
using WebApp.Model;

namespace WebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> movies { get; set; }
        public DbSet<CinemaHall> cinemaHalls { get; set; }
        public DbSet<Showing> showings { get; set; }
        public DbSet<Ticket> tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Showings)
                .WithOne(s => s.Movie)
                .HasForeignKey(s => s.MovieId);

            modelBuilder.Entity<CinemaHall>()
                .HasMany(m => m.Showings)
                .WithOne(c => c.CinemaHall)
                .HasForeignKey(c => c.CinemaHallId);

            //modelBuilder.Entity<Showing>()
            //    .HasMany(t => t.Tickets)
            //    .WithOne(m => m.Showing)
            //    .HasForeignKey(m => m.TicketId);

            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    movieId = 1,
                    title = "Zołza",
                    description = "Anna Sobańska (Małgorzata Kożuchowska) vel „Zołza”, „Królowa”, „Szekspir”. Dotychczasowy bilans życiowy: 1 mąż, 2 dzieci, 36 statuetek, 40 milionów widzów. Liczba osób, które nie widziały jej twórczości filmowej: hmmm – być może 2 lub 3. Liczba bohaterów, których wymyśliła: 186. Liczba dotychczasowych porażek w życiu osobistym i zawodowym: 0 (przynajmniej tak jej się wydaje). Nadchodzące załamania nerwowe: 1 Anna to kobieta sukcesu i… niekwestionowana zołza. Jednym skinieniem kreuje gwiazdy, a drugim je unicestwia. Chce być silna i idealna w każdym obszarze, choć nie widzi, że jej życie jest dalekie od świata, który kreuje na ekranie. Kiedy jednak wydaje jej się, że ma wszystko, życie postanawia utrzeć jej nosa. Co z tego wyniknie? Czy Zołza zapanuje nad własnym życiem?",
                    year = 2022,
                    length = 96,
                    posterURL = "https://www.crew-united.com/Media/Images/1558/1558327/1558327.entity.jpg"
                },
                new Movie()
                {
                movieId = 2,
                    title = "Guliwer",
                    description = "Światowej sławy podróżnik i poszukiwacz przygód Guliwer zostaje ponownie zaproszony do krainy Liliputów, którą wcześniej ocalił przed wrogą flotą sąsiedniego kraju Blefuscu. Dochodzi jednak do nieporozumienia, bowiem mieszkańcy oczekują, że u ich bram stanie olbrzym wielkości solidnego budynku, który samym swoim wyglądem odstraszy każdego wroga. Nic jednak z tego, bowiem Guliwer jest zwyczajnego wzrostu i niczym się w tym względzie nie różni od pozostałych mieszkańców. Rozczarowany król wtrąca przybysza do lochu. Tymczasem niezwyciężona armada Blefuscu pod komendą jej żądnego podbojów dowódcy przygotowuje kolejną inwazję. Los pokojowej krainy leży teraz w rękach Guliwera, jego dzielnego mysiego kompana i nowo poznanej przyjaciółki. Do pokonania licznej armii wroga potrzebna będzie nie siła, a spryt.",
                    year = 2021,
                    length = 90,
                    posterURL = "https://maxkino.eu/wp-content/uploads/2022/08/8b66f6e70a1ff629f54c79d1d0a13de1.jpeg"
                },
                new Movie()
                {
                    movieId = 3,
                    title = "Nie matrw się, kochanie",
                    description = "Lata 50. Gospodyni domowa mieszkająca z mężem w utopijnej, eksperymentalnej społeczności, zaczyna się niepokoić, że jego pełna przepychu firma może skrywać niepokojące tajemnice.",
                    year = 2022,
                    length = 122,
                    posterURL = "https://fwcdn.pl/fpo/37/84/853784/8027899.3.jpg"
                },
                new Movie()
                {
                    movieId = 4,
                    title = "Sierota. Narodziny zła",
                    description = "Psychopatyczna morderczyni o wyglądzie dziecka podszywa się pod zaginioną dziewczynkę.",
                    year = 2022,
                    length = 98,
                    posterURL = "https://ftmp.helios.pl/Get/file/mvpstr/25395/1660809618"
                },
                new Movie()
                {
                    movieId = 5,
                    title = "Tedi i szmaragdowa tablica",
                    description = "Największym marzeniem Tediego jest zostać zaakceptowanym przez kolegów archeologów. Kiedy niechcący niszczy egipski sarkofag, ściąga na siebie i swoich przyjaciół klątwę. Uratowanie Mumii, Jeffa i Belzoniego zapoczątkuje pełną akcji przygodę. Wraz z Sarą przemierzy pół świata, aby odwrócić klątwę Szmaragdowej Tablicy.",
                    year = 2022,
                    length = 90,
                    posterURL = "https://www.filmy-animowane.pl/wp-content/uploads/2022/07/tedi-i-szmaragdowa-tablica-plakat-600x900.jpg"
                },
                new Movie()
                {
                    movieId = 6,
                    title = "Bilet do raju",
                    description = "",
                    year = 2022,
                    length = 104,
                    posterURL = "https://media.multikino.pl/thumbnails/50/rc/NUVBNEU5/eyJ0aHVtYm5haWwiOnsic2l6ZSI6WyIxMDAwMCIsIjEwMDAwIl0sIm1vZGUiOiJpbnNldCJ9fQ==/uploads/images/films_and_events/bilet-do-raju-plakat-online-cut_7849fe162d.jpg"
                },
                new Movie()
                {
                    movieId = 7,
                    title = "Zobacz Anioła",
                    description = "Pisarze, wierni i duchowni kościoła Katolickiego, w miejscach objawień i kultu Świętego Michała Archanioła, odkrywają tajemnicę pierwszego pośród Aniołów Światłości. Świadectwo wiary, historia Kościoła, architektura i sztuka w kulturze chrześcijańskiej przybliża widzom niezwykłą postać Archanioła Michała. Dokument pobudza do refleksji nad rzeczywistością świata Aniołów Bożych i eschatologiczną misją, jaką wypełnia ich wódz. Ten wspaniały dokument zabiera nas po największych sanktuariach Świętego Michała Archanioła między innymi: Monte Snat`Angelo – Gargano-Włochy, Mont Saint Michele – Francja, Rzym - Włochy, Santa Maria La Nova – Włochy, Jasna Góra – Polska. Misję Świętego Michała przybliżą nam wspaniali goście: Abp Henryk Hoser, Ks. Marcello Stanzione, Ks. Henri Gesmier, Ks. Dariusz Wilk oraz osoby które doświadczyły obecności Świętego Michała na Ziemi.",
                    year = 2022,
                    length = 90,
                    posterURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZQSy80wTVR8LomPDeT8NTxTZkkfpluxGR_chukTrm0f-u_qHlhAa1CtKIr9YIu5l8_6g&usqp=CAU"
                },
                new Movie()
                {
                    movieId = 8,
                    title = "Asterix i Obelix: Misja Kleopatra",
                    description = "Asterix, Obelix i Panoramix wyruszają do Egiptu, by pomóc architektowi Numernabisowi. Ma on zaledwie trzy miesiące na wybudowanie pałacu dla Kleopatry.",
                    year = 2002,
                    length = 107,
                    posterURL = "https://fwcdn.pl/fpo/08/96/30896/6900390.3.jpg"
                }
                );
            modelBuilder.Entity<CinemaHall>().HasData(
                new CinemaHall() { CinemaHallId = 1, CinemaHallName = "1", ColumnCount = 10, RowCount = 5 },
                new CinemaHall() { CinemaHallId = 2, CinemaHallName = "2", ColumnCount = 10, RowCount = 5 }
                );

            modelBuilder.Entity<Showing>().HasData(
                    new Showing()
                    {
                        ShowingId = 1,
                        CinemaHallId = 1,
                        MovieId = 2,
                        Date = DateTime.Today,
                        TicketPrice = 20,
                        Dubbing = false
                    },
                    new Showing()
                    {
                        ShowingId = 2,
                        CinemaHallId = 1,
                        MovieId = 2,
                        Date = DateTime.Today.AddDays(1),
                        TicketPrice = 20,
                        Dubbing = false
                    }
                    );
            modelBuilder.Entity<Ticket>().HasData(
                    new Ticket()
                    {
                        TicketId = 1,
                        ShowingId = 1,
                        RowNumber = 3,
                        ColumnNumber = 2,

                    },
                    new Ticket()
                    {
                        TicketId = 2,
                        ShowingId = 2,
                        RowNumber = 2,
                        ColumnNumber = 1,
                    },
                    new Ticket()
                    {
                        TicketId = 3,
                        ShowingId = 1,
                        RowNumber = 2,
                        ColumnNumber = 6,
                    }
                    );
        }
    }
}
