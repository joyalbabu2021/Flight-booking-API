using Flight_booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.DTO
{
    public class AvailableFlightTripsDTO : FlightTripSchedule
    {
        //public AirlineMasterModel Airline { get; set; }
        //public int FlightId { get; set; }
        //public string FlightNumber { get; set; }
        //public decimal Amount { get; set; }
        //public decimal ReturnAmount { get; set; }
        //public decimal TotalAmount { get; set; }
        public string TripType { get; set; }

    }
}
