using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
using Flight_booking.Models;
using Flight_booking.Context;
using Flight_booking.DTO;

namespace Flight_booking.Repositories
{
    public class airline:Iairline
    {
        private FDbcontext context;

        public airline(FDbcontext _context)
        {
            this.context = _context;
        }
        public async Task<Tuple<bool, string>> Insertflightdata(Airlinesmodel airline)
        {
            var message = "insert successfully";
            Airlinesmodel Airlinemodel = new Airlinesmodel();
            var pnrnumber = Convert.ToInt32(DateTime.Now);
            if (airline != null)
            {
                Airlinemodel.Airlinename = airline.Airlinename;
                Airlinemodel.Airlinelogo = airline.Airlinelogo;
                Airlinemodel.instrumentused = airline.instrumentused;
                Airlinemodel.flightnumber = airline.flightnumber;
                Airlinemodel.Contactname = airline.Contactname;
                Airlinemodel.Contactnumber = airline.Contactnumber;
                Airlinemodel.From = airline.From;
                Airlinemodel.To = airline.To;
                
                context.airlinemodel.Add(airline);
                context.SaveChanges();
            }
            return Tuple.Create(true, message);
            
        }
        

        public async Task<List<Airlinesmodel>> GetAirlinesbyflighnumber(Airlinesmodel airline)
        {
            List<Airlinesmodel> airmodel = new List<Airlinesmodel>();
            airmodel = context.airlinemodel.Where(w => w.Airlinename == airline.Airlinename && w.flightnumber == airline.flightnumber && w.instrumentused == airline.instrumentused).ToList();

            return airmodel;
        }

        public Tuple<bool, string> InsertAirline(AirlineMasterModel airlineMasterModel)
        {
            if (airlineMasterModel != null) { 
            context.Airlines.Add(airlineMasterModel);
            context.SaveChanges();
            }
            string message = $"Airline {airlineMasterModel.AirlineName} created sucessfully";
            return Tuple.Create(true, message);
           
        }

       

        public AirlineMasterModel GetAirlinesDetails(int airlineId)
        {
           return context.Airlines.FirstOrDefault(a => a.AirlinesId == airlineId);
        }

        public Tuple<bool, string> AddFlightDetails(AddFlightDetailsDTO addFlightDetailsDTO)
        {
            var airline = context.Airlines.First(a => a.AirlinesId == addFlightDetailsDTO.AirlinesId);
            FlightModel flightModel = new FlightModel()
            {
                FlightId = 0,//identity and primary key colmun
                FlightNumber = addFlightDetailsDTO.FlightNumber,
                InstrumentUsed = addFlightDetailsDTO.InstrumentUsed,
                RowsCount = addFlightDetailsDTO.RowsCount,
                BusinessClassSeatsCount = addFlightDetailsDTO.BusinessClassSeatsCount,
                NonBusinessClassSeatsCount = addFlightDetailsDTO.NonBusinessClassSeatsCount,
                AirlinesId = addFlightDetailsDTO.AirlinesId,
                AirlineMasterModel = airline


            };
            context.Flights.Add(flightModel);
            context.SaveChanges();
            string message = $"Airline {addFlightDetailsDTO.FlightNumber} created sucessfully";
            return Tuple.Create(true, message);

        }

        public Tuple<bool, string> AddTripSchedule(AddTripScheduleDTO addTripScheduleDTO)
        {
            var flight = context.Flights.Where(f => f.FlightId == addTripScheduleDTO.FlightId).FirstOrDefault();

            FlightTripSchedule flightTripSchedule = new FlightTripSchedule()
            {
                TripId = addTripScheduleDTO.TripId,
                FromPlace = addTripScheduleDTO.FromPlace,
                ToPlace = addTripScheduleDTO.ToPlace,
                AvailableDate = addTripScheduleDTO.AvailableDate,
                StartDateTime = addTripScheduleDTO.StartDateTime,
                EndDateTime = addTripScheduleDTO.EndDateTime,
                SeatsAvailable = addTripScheduleDTO.SeatsAvailable,
                FlightId = addTripScheduleDTO.FlightId,
                Flight = flight,
            };
            context.FlightTrips.Add(flightTripSchedule);
            context.SaveChanges();
            string message = $"Trip Details for  {flight.FlightNumber} created sucessfully";
            return Tuple.Create(true, message);

        }
    }
}
