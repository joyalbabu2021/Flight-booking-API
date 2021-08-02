using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.DTO
{
    public class passengerdetailsDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Usermail { get; set; }
        public string Pnrnumber { get; set; }

        public string mealpreference { get; set; }

        public string selectedseatnumber { get; set; }
    }
}
