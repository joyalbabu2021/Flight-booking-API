using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
using Flight_booking.Models;
using Flight_booking.Context;
using Flight_booking.DTO;
using Microsoft.EntityFrameworkCore;

namespace Flight_booking.Repositories
{
    public class search : Isearch
    {
        private FDbcontext context;

        public search(FDbcontext _context)
        {
            this.context = _context;
        }
        public async Task<List<Airlinesmodel>> GetFlights(Flightbookingsmodel bookmodel)
        {
            List<Airlinesmodel> airlineslist = new List<Airlinesmodel>();

            List<Airlinesmodel> flightslist = context.airlinemodel.Where(d => d.Avilabledate == bookmodel.onwarddate && d.From == bookmodel.Fromplace && d.To == bookmodel.Toplace && d.Triptype == bookmodel.Triptype).ToList();
            List<Airlinesmodel> flightslist2 = context.airlinemodel.Where(d => d.Avilabledate == bookmodel.returndate && d.From == bookmodel.Fromplace && d.To == bookmodel.Toplace && d.Triptype == bookmodel.Triptype).ToList();
            if (bookmodel.Triptype == "oneway")
            {
                airlineslist = flightslist;
            }
            else
            {
                airlineslist = flightslist;
                airlineslist.AddRange(flightslist2);
            }
            return airlineslist;
        }

        public List<FlightTripSchedule> SearchFlights(SearchFlightDTO searchFlightDTO)
        {
            List<AvailableFlightTripsDTO> availableFlightTrips = new List<AvailableFlightTripsDTO>();
            List<AvailableFlightTripsDTO> onwardFlightTrip = new List<AvailableFlightTripsDTO>();
            List<AvailableFlightTripsDTO> returnFlightTrip = new List<AvailableFlightTripsDTO>();
            //Only show flights of airlines which are not blocked
            List<FlightTripSchedule> flightTripSchedules = context.FlightTrips
                                         .Include(f => f.Flight)
                                         .ThenInclude(a => a.AirlineMasterModel)
                                         .Where(t => t.AvailableDate.Date == searchFlightDTO.AvailableDate.Date 
                                                                            && t.FromPlace == searchFlightDTO.FromPlace && t.ToPlace == searchFlightDTO.ToPlace 
                                                                            && t.Flight.AirlineMasterModel.Blocked == false
                                                ).ToList();
            if (searchFlightDTO.TripType.ToString() != "oneway")
            {
                //just reverse the FromPlace and To Place and check for returndate
                flightTripSchedules.AddRange(context.FlightTrips.Include(f => f.Flight).ThenInclude(a => a.AirlineMasterModel).Where(t => t.AvailableDate.Date == searchFlightDTO.returnDateTime.Date && t.FromPlace == searchFlightDTO.ToPlace && t.ToPlace == searchFlightDTO.FromPlace && t.Flight.AirlineMasterModel.Blocked == false).ToList());
            }
            return flightTripSchedules;
        }


    }
}
