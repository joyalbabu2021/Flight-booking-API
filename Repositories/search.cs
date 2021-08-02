using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
using Flight_booking.Models;
using Flight_booking.Context;
using Flight_booking.DTO;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

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

        public List<AvailableFlightTripsDTO> SearchFlights(SearchFlightDTO searchFlightDTO,IMapper mapper)
        {
            List<AvailableFlightTripsDTO> availableFlightTrips = new List<AvailableFlightTripsDTO>();
            List<AvailableFlightTripsDTO> onwardFlightTrip = new List<AvailableFlightTripsDTO>();
            List<AvailableFlightTripsDTO> returnFlightTrip = new List<AvailableFlightTripsDTO>();
            //Only show flights of airlines which are not blocked and AvailableSeats > 0
            List<FlightTripSchedule> flightTripSchedules = context.FlightTrips
                                         .Include(f => f.Flight)
                                         .ThenInclude(a => a.AirlineMasterModel)
                                         .Where(t => t.AvailableDate.Date == searchFlightDTO.AvailableDate.Date 
                                                                            && t.FromPlace == searchFlightDTO.FromPlace && t.ToPlace == searchFlightDTO.ToPlace 
                                                                            && t.Flight.AirlineMasterModel.Blocked == false && t.SeatsAvailable >0
                                                ).ToList();
            onwardFlightTrip = mapper.Map<List<AvailableFlightTripsDTO>>(flightTripSchedules);
            onwardFlightTrip.ForEach(x => x.TripType = "oneway");
            availableFlightTrips.AddRange(onwardFlightTrip);
            if (searchFlightDTO.TripType.ToString() != "oneway")
            {
                //just reverse the FromPlace and To Place and check for returndate
                //flightTripSchedules.AddRange(context.FlightTrips.Include(f => f.Flight).ThenInclude(a => a.AirlineMasterModel).Where(t => t.AvailableDate.Date == searchFlightDTO.returnDateTime.Date && t.FromPlace == searchFlightDTO.ToPlace && t.ToPlace == searchFlightDTO.FromPlace && t.Flight.AirlineMasterModel.Blocked == false).ToList());
                List<FlightTripSchedule> returnFlights = context.FlightTrips.Include(f => f.Flight).ThenInclude(a => a.AirlineMasterModel).Where(t => t.AvailableDate.Date == searchFlightDTO.returnDateTime.Date && t.FromPlace == searchFlightDTO.ToPlace && t.ToPlace == searchFlightDTO.FromPlace && t.Flight.AirlineMasterModel.Blocked == false && t.SeatsAvailable > 0 ).ToList();
                returnFlightTrip = mapper.Map<List<AvailableFlightTripsDTO>>(returnFlights);
                returnFlightTrip.ForEach(x => x.TripType = "roundtrip");
                availableFlightTrips.AddRange(returnFlightTrip);
            }
           // return flightTripSchedules;
            return availableFlightTrips;
        }


    }
}
