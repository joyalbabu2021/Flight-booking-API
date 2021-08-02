using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Interfaces;
using Flight_booking.Models;
using Flight_booking.Context;
namespace Flight_booking.Repositories
{
    public class ticket : Iticket
    {
        private FDbcontext context;

        public ticket(FDbcontext _context)
        {
            this.context = _context;
        }
        public Flightbookingsmodel GetFlightdetailsbypnr(int pnr)
        {

            var bookedlist = context.bookmodel.Where(w => w.Pnrnumber == pnr.ToString()).FirstOrDefault();

            return bookedlist;
        }
    }
}
