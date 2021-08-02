using Flight_booking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.DTO
{
    public class FlightbookingDto
    {
        
        public string Username { get; set; }
        public string UserEmail { get; set; }
        public string Userid { get; set; }
        public string Triptype { get; set; }
        public string Discountcode { get; set; }
        public string Selectedseatonward { get; set; }
        public string Selectedseatreturn { get; set; }
        public DateTime onwarddate { get; set; }
        public DateTime returndate { get; set; }
        public decimal Amount { get; set; }
        public string Airlinename { get; set; }
        public string Airlinelogo { get; set; }
        public decimal ReturnAmount { get; set; }
        public string ReturnAirlinename { get; set; }
        public string ReturnAirlinelogo { get; set; }
        public decimal Totalamount { get; set; }
        public int status { get; set; }
        public string Fromplace { get; set; }
        public string Toplace { get; set; }
        public string Mealtype { get; set; }
        public string ReturnMealtype { get; set; }
        public int Pnrnumber { get; set; }
        public int TripId { get; set; }
        public int ReturnTripId { get; set; }
        public int passengersCount { get; set; }
        //public DateTime bookeddate { get; set; }
        //public int numberofseats { get; set; }
        [NotMapped] public ICollection<passengerdetailsDTO> passengerdetails { get; set; }

    }
}
