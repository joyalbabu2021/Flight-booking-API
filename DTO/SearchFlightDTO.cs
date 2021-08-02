using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.DTO
{
   
    public class SearchFlightDTO
    {
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime returnDateTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string TripType { get; set; }
    }
}
