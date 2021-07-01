using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.Models
{
    public class FlightModel
    {
        [Key]
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }

        public int AirlinesId { get; set; }
        public string InstrumentUsed { get; set; }
        public int RowsCount { get; set; }
        public int BusinessClassSeatsCount { get; set; }
        public int NonBusinessClassSeatsCount { get; set; }
        [NotMapped]
        public ICollection<string> ScheduledDays { get; set; }
        public AirlineMasterModel AirlineMasterModel { get; set; } //This property is  EF core Foriegn key relationship
        public virtual ICollection<FlightTripSchedule> FlightTripSchedules { get; set; }


    }
}
