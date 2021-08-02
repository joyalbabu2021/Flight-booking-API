using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.Models
{
    
    public class Flightbookingsmodel
    {
        [Key]
        public int FlightBookingId { get; set; }
        public string Username { get; set; }
        public string UserEmail { get; set; }
        public string Userid { get; set; }
        public string Triptype { get; set; }
        public string Discountcode { get; set; }
        public string Selectedseatonward { get; set; }
        public string Selectedseatreturn { get; set; }
        public DateTime onwarddate { get; set; }
        public DateTime returndate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public string Airlinename { get; set; }
        public string Airlinelogo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ReturnAmount { get; set; }
        public string ReturnAirlinename { get; set; }
        public string ReturnAirlinelogo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Totalamount { get; set; }
        public int status { get; set; }
        public string Fromplace { get; set; }
        public string Toplace { get; set; }
        public string Mealtype { get; set; }
        public string ReturnMealtype { get; set; }
        public string Pnrnumber { get; set; }
        public DateTime bookeddate { get; set; }
        public int numberofseats { get; set; }
        public int TripId { get; set; }
        public int ReturnTripId { get; set; }
        // [NotMapped]
        public virtual ICollection<passengerdetails> passengerdetails{ get; set; }
    }
}
