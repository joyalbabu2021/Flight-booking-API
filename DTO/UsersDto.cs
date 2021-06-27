using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.DTO
{
    public class UsersDto
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string UserEmail { get; set; }
        public string Username { get; set; }
    }
}
