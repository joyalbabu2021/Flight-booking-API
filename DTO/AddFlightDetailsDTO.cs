using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.DTO
{
    public class AddFlightDetailsDTO
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }

        public int AirlinesId { get; set; }
        public string InstrumentUsed { get; set; }
        public int RowsCount { get; set; }
        public int BusinessClassSeatsCount { get; set; }
        public int NonBusinessClassSeatsCount { get; set; }
        
    }
}
