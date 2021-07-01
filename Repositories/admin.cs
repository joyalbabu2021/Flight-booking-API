using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_booking.Context;
using Flight_booking.Interfaces;
using Flight_booking.Models;
using Microsoft.EntityFrameworkCore;

namespace Flight_booking.Repositories
{
    public class admin : Iadmin
    {
        private FDbcontext context;
        public admin(FDbcontext _context)
        {
            this.context = _context;
        }
        public Usersmodel GetUserDetails(int UserID)
        {
            return context.usermodel.Where(u => u.UserID == UserID).FirstOrDefault();
        }

        public Usersmodel GetUserDetails(string userEmail)
        {
            return context.usermodel.Where(u => u.UserEmail == userEmail).FirstOrDefault();
        }

        public async Task<List<Usersmodel>> GetUsers()
        {
            return await context.usermodel.ToListAsync();

        }
        public async Task<List<FlightModel>> GetFlightsList()
        {
            return await context.Flights.Include(f => f.AirlineMasterModel).Where(f => f.AirlineMasterModel.Blocked == false).ToListAsync();
        }

        /* public dynamic GetFlightDetailsById(int FlightId)
         {
             return context.Flights.Where(f=>f.FlightId==FlightId).Join(context.Airlines, F => F.AirlinesId, A => A.AirlinesId,
                  (F, A) => new
                  {
                      FlightId = F.FlightId,
                      FlightNumber = F.FlightNumber,
                      InstrumentUsed = F.InstrumentUsed,
                      RowsCount = F.RowsCount,
                      aa=F.NonBusinessClassSeatsCount,
                      dd=F.BusinessClassSeatsCount,
                      AirlineName = A.AirlineName,
                      AirlinesId = A.AirlinesId,
                      AirlineLogo = A.AirlineLogo
                  }
                 );
         }*/

        public FlightModel GetFlightDetailsById(int FlightId) =>  context.Flights.Include(f => f.AirlineMasterModel).FirstOrDefault(f => f.FlightId == FlightId);
    }  
}
