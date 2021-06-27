using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.DTO
{
    public class Airlinedto
    {
        public string Airlinename { get; set; }
        public byte[] Airlinelogo { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Avilabledate { get; set; }
        public string Triptype { get; set; }
        public int Cost { get; set; }
        public string Contactnumber { get; set; }
        public string Contactname { get; set; }
        public int flightnumber { get; set; }
        public string instrumentused { get; set; }
        //comment
    }
}
