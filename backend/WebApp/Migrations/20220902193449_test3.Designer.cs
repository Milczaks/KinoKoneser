// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Data;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220902193449_test3")]
    partial class test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            description = "AA",
                            length = 150,
                            posterURL = "https://i.etsystatic.com/22295500/r/il/bd145e/2433214065/il_794xN.2433214065_q359.jpg",
                            title = "AAA",
                            year = 2022
                        });
                });

            modelBuilder.Entity("WebApp.Model.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"), 1L, 1);

                    b.Property<int>("ColumnNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<int>("ShowingId")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("ShowingId");

                    b.HasIndex("TicketId");

                    b.ToTable("reservations");
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
                });

            modelBuilder.Entity("WebApp.Model.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"), 1L, 1);

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("QRString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QRStringImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketId");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("WebApp.Model.Reservation", b =>
                {
                    b.HasOne("WebApp.Model.Showing", "Showing")
                        .WithMany("Reservations")
                        .HasForeignKey("ShowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Model.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Showing");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("WebApp.Model.Showing", b =>
                {
                    b.HasOne("WebApp.Model.CinemaHall", "CinemaHall")
                        .WithMany()
                        .HasForeignKey("CinemaHallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Model.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaHall");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("WebApp.Model.Showing", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
