using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StageManagment.Entities;
using System.ComponentModel.Design.Serialization;

namespace StageManagment
{
    public class DbContextStageManagment : DbContext
    {
        public DbContextStageManagment()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().HasIndex(a => a.Username).IsUnique();

            modelBuilder.Entity<ProgramStage>().Property(p => p.PriceInEuro).HasPrecision(10, 2);
            modelBuilder.Entity<ProgramStage>().Property(p => p.StartPriceInEuro).HasPrecision(10, 2);
            modelBuilder.Entity<ProgramStage>().Property(p => p.EndPriceInEuro).HasPrecision(10, 2);

            modelBuilder.Entity<Ticket>().Property(t => t.PriceInEuro).HasPrecision(10, 2);
            modelBuilder.Entity<Ticket>().Property(t => t.PaydPriceInEuro).HasPrecision(10, 2);

            // seed data

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    AccountId = 1,
                    Username = "admin",
                    HashPassword = BCrypt.Net.BCrypt.HashPassword("admin")
                });

            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    Name = "Bushido",
                    ArtistCategorie = ArtistCategorie.Musiker,
                });

            modelBuilder.Entity<ProgramStage>().HasData(
                new ProgramStage
                {
                    ProgramStageId = 1,
                    Name = "Junge berliner",
                    DurationInMinutes = 150,
                    PriceInEuro = 100,
                    StartPriceInEuro = 0,
                    EndPriceInEuro = 100,
                    IsPayd = true,
                    ArtistId = 1
                });

            modelBuilder.Entity<Performance>().HasData(
                new Performance
                {
                    PerformanceId = 1,
                    Name = "Teil1",
                    StartPerformance = new DateTime(2024, 09, 16, 10, 00, 00),
                    EndPerformance = new DateTime(2024, 09, 16, 11, 00, 00),
                    IsActive = true,
                    ProgramStageId = 1,
                });

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    TicketId = 1,
                    SeatRow = SeatRow.A,
                    SeatNumber = 1,
                    PriceInEuro = 50,
                    PaydPriceInEuro = 50,
                    CustomerFirstname = "Mert",
                    CustomerLastname = "Can",
                    CustomerAddress = "Hohenesmeserstarsse 12",
                    CustomerPLZ = 8454,
                    CustomerCountry = "Hohenems",
                    CustomerCategorie = CustomerCategorie.Normal,
                    PerformanceId = 1,
                });
        }

        public DbSet<Entities.Account> Accounts { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ProgramStage> ProgramStages { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
