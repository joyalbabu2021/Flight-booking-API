using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Models;

namespace Flight_booking.Interfaces
{
   
    public interface Isearch
    {
        Task<List<Airlinesmodel>> GetFlights(Flightbookingsmodel bookmodel);
    }
}
