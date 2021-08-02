using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.Models
{
    //Master Data of Trip Scheduled by Admin .. its details of the Trips availble or flights available for a day
    public class FlightTripSchedule
    {
        [Key]
        public int TripId { get; set; }
        
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        [NotMapped]
        public virtual ICollection<string> MealType { get; set; }
        public int SeatsAvailable { get; set; }
        public int FlightId { get; set; }
        
        public virtual FlightModel Flight { get; set; }
        public int costPerSeat { get; set; }

    }
}
