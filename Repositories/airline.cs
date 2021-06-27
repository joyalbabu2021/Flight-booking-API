using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
using Flight_booking.Models;
using Flight_booking.Context;

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
    }
}
