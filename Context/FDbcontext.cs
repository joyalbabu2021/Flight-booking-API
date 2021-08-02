using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Models;
using Microsoft.EntityFrameworkCore;
namespace Flight_booking.Context
{
    public class FDbcontext : DbContext
    {
        public FDbcontext(DbContextOptions<FDbcontext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Usersmodel>()
            .HasData(
                new Usersmodel
                {
                    UserID = 1,
                    UserEmail = "Surya.Teja@gmail.com",
                    Password = "Ind@3333",
                    Role = "user",
                    Username = "Surya Teja"
                },
                new Usersmodel
                {
                    UserID = 2,
                    UserEmail = "Surya.Teja2@gmail.com",
                    Password = "Ind@3333",
                    Role = "user",
                    Username = "Surya Teja2"
                }

                );

            #region seed-Flightbookingsmodel

            modelBuilder.Entity<Flightbookingsmodel>()
                //.HasNoKey()
                .HasData(
                new Flightbookingsmodel
                {
                    FlightBookingId = 1,
                    Username = "Jack",
                    UserEmail = "Jack.Reacher@gmail.com",
                    Userid = "1",
                    Triptype = "sampelTriptype",
                    Discountcode = "DC100",
                    Selectedseatonward = "A1",
                    Selectedseatreturn = "A2"
                    ,
                    onwarddate = DateTime.Now.AddDays(5)
                    ,
                    returndate = DateTime.Now.AddDays(7)
                    ,
                    Amount = 2504
                    ,
                    Airlinename = "SpiceJet"
                    ,
                    Airlinelogo = ""
                    ,
                    ReturnAmount = 2504
                    ,
                    ReturnAirlinename = "SpiceJet"
                    ,
                    ReturnAirlinelogo = "ssss"
                    ,
                    Totalamount = 5008
                    ,
                    status = 1
                    ,
                    Fromplace = "Hyderabad"
                    ,
                    Toplace = "Bangalore"
                    ,
                    Mealtype = "SampleMeal"
                    ,
                    ReturnMealtype = "SampleMeal"
                    ,
                    Pnrnumber = "123456"
                    ,
                    bookeddate = DateTime.Now
                   ,
                    numberofseats = 2
                    ,
                    //        passengerdetails = new[] {
                    //new passengerdetails() { Name="Surya",Age=25,Gender="M",Usermail="Surya.Teja@gmail.com",Pnrnumber=12345,mealpreference="mealpref",selectedseatnumber="A1"}
                    //,new passengerdetails() { Name="Teja",Age=26,Gender="M",Usermail="Surya.Teja2@gmail.com",Pnrnumber=67890,mealpreference="mealpref",selectedseatnumber="A2"}
                    //        }
                }

                , new Flightbookingsmodel
                {
                    FlightBookingId = 2,
                    Username = "Jack2",
                    UserEmail = "Jack.Reacher2@gmail.com",
                    Userid = "2",
                    Triptype = "TwoWayTrip",
                    Discountcode = "DC100",
                    Selectedseatonward = "B1",
                    Selectedseatreturn = "B2"
                    ,
                    onwarddate = DateTime.Now.AddDays(5)
                    ,
                    returndate = DateTime.Now.AddDays(7)
                    ,
                    Amount = 2504
                    ,
                    Airlinename = "SpiceJet"
                    ,
                    Airlinelogo = ""
                    ,
                    ReturnAmount = 2504
                    ,
                    ReturnAirlinename = "Indigo"
                    ,
                    ReturnAirlinelogo = "ssss"
                    ,
                    Totalamount = 5008
                    ,
                    status = 1
                    ,
                    Fromplace = "Hyderabad"
                    ,
                    Toplace = "Delhi"
                    ,
                    Mealtype = "SampleMeal"
                    ,
                    ReturnMealtype = "SampleMeal"
                    ,
                    Pnrnumber = "789012"
                    ,
                    bookeddate = DateTime.Now
                   ,
                    numberofseats = 1
                    ,
                    //        passengerdetails = new[] {
                    //new passengerdetails() { Name="Surya",Age=25,Gender="M",Usermail="Surya.Teja@gmail.com",Pnrnumber=12345,mealpreference="mealpref",selectedseatnumber="A1"}
                    //,new passengerdetails() { Name="Teja",Age=26,Gender="M",Usermail="Surya.Teja2@gmail.com",Pnrnumber=67890,mealpreference="mealpref",selectedseatnumber="A2"}
                    //        }
                }


                );
            #endregion


            modelBuilder.Entity<passengerdetails>(entity =>
            {
                entity.HasOne(d => d.flightbookingsmodel)
                .WithMany(p => p.passengerdetails)
                .HasForeignKey("flightbookingid");
            });

            #region Seed-PassengerDetails
            modelBuilder.Entity<passengerdetails>().HasData(
               new passengerdetails() { Id = 1, flightbookingid = 1, Name = "Jack", Age = 25, Gender = "M", Usermail = "Jack.Reacher@gmail.com", Pnrnumber = "12345", mealpreference = "mealpref", selectedseatnumber = "A1" },
                new passengerdetails() { Id = 2, flightbookingid = 1, Name = "J Reacher", Age = 25, Gender = "M", Usermail = "Jack.Reacher2@gmail.com", Pnrnumber = "12345", mealpreference = "mealpref", selectedseatnumber = "A2" },
                 new passengerdetails() { Id = 3, flightbookingid = 2, Name = "J Reacher3", Age = 25, Gender = "M", Usermail = "Jack.Reacher3@gmail.com", Pnrnumber = "789012", mealpreference = "mealpref", selectedseatnumber = "B1" }
                                                  );

            #endregion

            #region Seed_AirlineMaster

            modelBuilder.Entity<AirlineMasterModel>()
                        .HasData(
                new AirlineMasterModel() { AirlinesId = 1, AirlineName = "Air India", AirlineLogo = "AirIndia.jpg", Blocked = false }
                , new AirlineMasterModel() { AirlinesId = 2, AirlineName = "SpiceJet", AirlineLogo = "SpiceJet.jpg", Blocked = false }
                , new AirlineMasterModel() { AirlinesId = 3, AirlineName = "IndiGo", AirlineLogo = "IndiGo.jpg", Blocked = false }
                );
            #endregion
            modelBuilder.Entity<FlightModel>(entity =>
            {
                entity.HasOne(d => d.AirlineMasterModel)
                .WithMany(p => p.Flights)
                .HasForeignKey("AirlinesId");
            });

            #region SeedFlightModel
            modelBuilder.Entity<FlightModel>().HasData(
                new FlightModel()
                {
                    AirlinesId = 1,
                    FlightId = 1,
                    FlightNumber = "AI300",
                    InstrumentUsed = "A320Neo",
                    RowsCount = 50,
                    BusinessClassSeatsCount = 20,
                    NonBusinessClassSeatsCount = 80,
                    ScheduledDays = new List<string>() { "WeeekDays" }
                }
                , new FlightModel()
                {
                    AirlinesId = 1,
                    FlightId = 2,
                    FlightNumber = "AI301",
                    InstrumentUsed = "A320",
                    RowsCount = 50,
                    BusinessClassSeatsCount = 20,
                    NonBusinessClassSeatsCount = 80,
                    ScheduledDays = new List<string>() { "Daily" }
                }
                , new FlightModel()
                {
                    AirlinesId = 2,
                    FlightId = 3,
                    FlightNumber = "SP100",
                    InstrumentUsed = "A320",
                    RowsCount = 60,
                    BusinessClassSeatsCount = 30,
                    NonBusinessClassSeatsCount = 90,
                    ScheduledDays = new List<string>() { "Weekends" }
                }

                );
            #endregion

            modelBuilder.Entity<FlightTripSchedule>(entity =>
            {
                entity.HasOne(d => d.Flight)
                .WithMany(p => p.FlightTripSchedules)
                .HasForeignKey("FlightId");
            });

            #region fillFlightTripSchedule

            modelBuilder.Entity<FlightTripSchedule>().HasData(
                new FlightTripSchedule()
                {
                    TripId=2,
                    FromPlace = "Tirupathi",
                    ToPlace = "Hyderabad",
                    AvailableDate = DateTime.Now,
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now.AddHours(2),
                    SeatsAvailable=100,
                    FlightId=2,
                    MealType= new List<string>() { "Veg","NonVeg" }
                }

                );
            ;

            #endregion
        }

        public DbSet<Flightbookingsmodel> bookmodel { get; set; }
        public DbSet<Airlinesmodel> airlinemodel { get; set; }
        public DbSet<Usersmodel> usermodel { get; set; }
        public DbSet<passengerdetails> PassengerDetails { get; set; }
        public DbSet<AirlineMasterModel> Airlines { get; set; }
        public DbSet<FlightModel> Flights { get; set; }
        public DbSet<FlightTripSchedule> FlightTrips { get; set; }

    }
}
