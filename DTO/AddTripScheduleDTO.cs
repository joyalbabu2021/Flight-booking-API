﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.DTO
{
    public class AddTripScheduleDTO
    {
        public int TripId { get; set; }

        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        
        public virtual ICollection<string> MealType { get; set; }
        public int SeatsAvailable { get; set; }
        public int FlightId { get; set; }

    }
}
