using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.Models
{
    //This is the Master Data of the Airlines
    public class AirlineMasterModel
    {
        [Key]
        public int AirlinesId { get; set; }
        public string AirlineName { get; set; }
        public string AirlineLogo { get; set; }
        public bool Blocked { get; set; } //if the Airline Blocked then its flights wont be shown in search

        public virtual ICollection<FlightModel> Flights { get; set; } //This property is  EF core Foriegn key relationship
    }
}
