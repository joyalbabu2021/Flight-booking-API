using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Models;

namespace Flight_booking.Interfaces
{
   public interface Iadmin
    {
        Usersmodel GetUserDetails(int UserID);
        Task<List<Usersmodel>> GetUsers();
        Usersmodel GetUserDetails(string userEmail);
        Task<List<FlightModel>> GetFlightsList();
        FlightModel GetFlightDetailsById(int FlightId);
    }
}
