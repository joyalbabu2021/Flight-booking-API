using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Models;

namespace Flight_booking.Interfaces
{
   public  interface Iairline
    {
        Task<Tuple<bool, string>> Insertflightdata(Airlinesmodel airline);
        Task<List<Airlinesmodel>> GetAirlinesbyflighnumber(Airlinesmodel airline);
    }
}
