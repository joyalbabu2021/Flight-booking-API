using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.DTO;
using Flight_booking.Models;

namespace Flight_booking.Interfaces
{
   public  interface Ibooking
    {
        Task<Tuple<bool, string>> Insertbookingdata(Flightbookingsmodel bookingmodel);
        Task<List<Flightbookingsmodel>> GetFlightdetailsbymail(string emailid);
        Task<Tuple<bool, string>> cancelflightbypnr(int pnr);
        Task<Flightbookingsmodel> GetFlightBookingDetailsbyId(int flightBookingId);

        Task<List<Flightbookingsmodel>> GetflightBookingHistory();
        Tuple<bool, string> ReserveTicketForUser(FlightbookingDto flightbookingDto);




    }
}
