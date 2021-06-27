using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
using Flight_booking.Models;
using Flight_booking.Context;

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
            if (bookmodel.Triptype=="oneway")
            {
                airlineslist=flightslist;
            }
            else
            {
                airlineslist = flightslist;
                airlineslist.AddRange(flightslist2);
            }
            return airlineslist;
        }
    }
}
