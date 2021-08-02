using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.Models
{
    //[Keyless]
    public class passengerdetails
    {
       [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Usermail { get; set; }
        public string Pnrnumber { get; set; }

        public string mealpreference { get; set; }

        public string selectedseatnumber { get; set; }
        public int flightbookingid { get; set; }

        public Flightbookingsmodel flightbookingsmodel { get; set; }

    }
}
