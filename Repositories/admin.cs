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
        public  Usersmodel GetUserDetails(int UserID)
        {
            return   context.usermodel.Where(u => u.UserID == UserID).FirstOrDefault();
        }

        public Usersmodel GetUserDetails(string userEmail)
        {
            return context.usermodel.Where(u => u.UserEmail == userEmail).FirstOrDefault();
        }

        public async Task<List<Usersmodel>> GetUsers()
        {
            return await context.usermodel.ToListAsync();

        }
        
    }
}
